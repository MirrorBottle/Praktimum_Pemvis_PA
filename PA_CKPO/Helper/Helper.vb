Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Module Helper

    Public Const PO_PENDING As String = "0"
    Public Const PO_ADMIN_APPROVED As String = "1"
    Public Const PO_LOGISTIC_APPROVED As String = "2"
    Public Const PO_DONE As String = "3"
    Public Function HashPassword(password As String) As String
        Dim sha256 As SHA256 = SHA256.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Return Convert.ToBase64String(hash)
    End Function

    Public Sub ShowMessage(ByVal message As String, Optional ByVal type As String = "")
        Dim icon As MessageBoxIcon
        Dim button As MessageBoxButtons

        'Set the icon and button based on the type parameter
        Select Case type
            Case "Success"
                icon = MessageBoxIcon.Information
                button = MessageBoxButtons.OK
            Case "Error"
                icon = MessageBoxIcon.Error
                button = MessageBoxButtons.OK
            Case "Info"
                icon = MessageBoxIcon.Information
                button = MessageBoxButtons.OK
            Case Else
                'Default to showing an information dialog box
                icon = MessageBoxIcon.Information
                button = MessageBoxButtons.OK
        End Select

        'Display the dialog box with the specified message, icon, and button
        MessageBox.Show(message, My.Application.Info.Title, button, icon)
    End Sub

    Public Sub FormClear(form As Form)
        For Each control As Control In form.Controls
            If TypeOf control Is TextBox Then
                Dim textBox As TextBox = DirectCast(control, TextBox)
                textBox.Clear()
            ElseIf TypeOf control Is ComboBox Then
                Dim comboBox As ComboBox = DirectCast(control, ComboBox)
                comboBox.SelectedIndex = -1
            ElseIf TypeOf control Is CheckBox Then
                Dim checkBox As CheckBox = DirectCast(control, CheckBox)
                checkBox.Checked = False
                ' Add more conditions for other types of input controls as needed
            End If
        Next
    End Sub

    Public Function FormValidate(form As Form, Optional excludedControlNames As List(Of String) = Nothing) As Boolean
        For Each ctrl As Control In form.Controls
            If TypeOf ctrl Is TextBox Or
           TypeOf ctrl Is ComboBox Or
           TypeOf ctrl Is CheckBox Or
           TypeOf ctrl Is RadioButton Or
           TypeOf ctrl Is DateTimePicker Then

                ' Check if excludedControlNames is provided and the control name is in the excluded list
                If excludedControlNames IsNot Nothing AndAlso excludedControlNames.Contains(ctrl.Name) Then
                    Continue For ' Skip validation for excluded control
                End If

                If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                    If String.IsNullOrEmpty(ctrl.Text) Then
                        Return False ' At least one input is empty
                    End If
                ElseIf TypeOf ctrl Is CheckBox Then
                    If DirectCast(ctrl, CheckBox).Checked = False Then
                        Return False ' At least one checkbox is unchecked
                    End If
                ElseIf TypeOf ctrl Is RadioButton Then
                    Dim radioButton As RadioButton = DirectCast(ctrl, RadioButton)
                    Dim radioGroup As Control.ControlCollection = radioButton.Parent.Controls
                    If radioGroup.OfType(Of RadioButton)().Any(Function(rb) rb.Checked) = False Then
                        Return False ' No radio button in the group is checked
                    End If
                ElseIf TypeOf ctrl Is DateTimePicker Then
                    Dim dateTimePicker As DateTimePicker = DirectCast(ctrl, DateTimePicker)
                    If dateTimePicker.Checked = False Then
                        Return False ' At least one DateTimePicker is unchecked
                    End If
                End If
            End If
        Next

        Return True ' All inputs are filled
    End Function

    Public Sub FormPopulateCmb(query As String, comboBox As ComboBox, displayMember As String, Optional valueMember As String = "id")
        Dim dt As DataTable = ExecuteQuery(query)
        comboBox.DataSource = Nothing
        comboBox.Items.Clear()
        comboBox.DataSource = dt
        comboBox.DisplayMember = displayMember
        comboBox.ValueMember = valueMember
    End Sub

    Public Function Parse(numberString) As Integer
        Dim sanitizedString As String = numberString.Replace(".", "") ' Remove the dot separator
        Dim number As Integer

        If Integer.TryParse(sanitizedString, number) Then
            Return number
        Else
            Return 0
        End If
    End Function

    Public Function NumberFormat(number As Integer) As String
        Return number.ToString("N0", Globalization.CultureInfo.InvariantCulture).Replace(",", ".")
    End Function

    Public Function GetNextPurchaseOrderCode() As String
        Dim query As String = "SELECT MAX(code) FROM purchase_orders"

        Dim resultTable As DataTable = SqlHelper.ExecuteQuery(query)

        If resultTable.Rows.Count > 0 AndAlso Not IsDBNull(resultTable.Rows(0)(0)) Then
            Dim maxCode As String = resultTable.Rows(0)(0).ToString()

            Dim numericPart As String = maxCode.Substring(3)
            Dim numericValue As Integer

            If Integer.TryParse(numericPart, numericValue) Then
                Dim nextNumericValue As Integer = numericValue + 1
                Dim nextCode As String = nextNumericValue.ToString("D3")

                Return "PO-" & nextCode
            End If
        End If

        Return "PO-001"
    End Function
End Module
