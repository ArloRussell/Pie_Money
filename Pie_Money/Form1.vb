Imports Newtonsoft.Json

Public Class Form1
    Private Const strSTUDENTFILE As String = "StudentList.json"
    Private StudentTable As New List(Of Student) 'TODO: Change To List
    Private names() As String = {"Aiden", "Alexander", "Anna", "Anthony", "Arlo", "Benjamin", "Bradley", "Brooks", "Chevy", "Collin", "Francis", "Holly", "Logan", "Matthew", "Michael", "Nathan", "Preston", "Srikar", "Tanmay", "Vincent", "Walker", "Zeph"}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateStudentTable()
        PopulateStudentComboBox()
        UpdateValues()
    End Sub

    Private Sub PopulateStudentTable()
        If IO.File.Exists(strSTUDENTFILE) Then
            'Stubbed
            'TODO: Load the list
            LoadStudentTableFromFile()
        Else
            StartFresh()
        End If
    End Sub

    Private Sub LoadStudentTableFromFile()
        Dim reader As New IO.StreamReader(strSTUDENTFILE)
        Dim str As String = reader.ReadToEnd
        StudentTable = JsonConvert.DeserializeObject(Of List(Of Student))(str)
        reader.Close()
    End Sub

    Private Sub StartFresh()
        For Each s As String In names
            StudentTable.Add(New Student(s, New List(Of Donation)))
        Next
    End Sub

    Private Sub PopulateStudentComboBox()
        cboStudents.Items.AddRange(StudentTable.ToArray)
    End Sub

    Private Sub cboStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudents.SelectedIndexChanged
        UpdateValues()
    End Sub

    Private Sub UpdateValues()
        Dim s As Student = cboStudents.SelectedItem
        If Not IsNothing(s) Then
            LoadDonationListBox()
            TxtStuTot.Text = s.GetTotalDonations.ToString()
            lblClassTotal.Text = GetClassTotalDonations.ToString("C2")
        End If
        PopulateTopDonors()
    End Sub
    ''' <summary>
    ''' Finds top five donors and sorts them by amount (Does not currently sort by amount.)
    ''' </summary>
    Private Sub PopulateTopDonors()
        lblHigh.Text = ""
        StudentTable.Sort(Function(x, y) y.GetTotalDonations.CompareTo(x.GetTotalDonations))
        Dim i As Integer = 0
        While i < 5 AndAlso StudentTable(i).GetTotalDonations > 0
            Dim s As Student = StudentTable(i)
            lblHigh.Text = $"{lblHigh.Text} {s.Name.PadRight(10)} {s.GetTotalDonations.PadLeft(8)}" & vbNewLine
            i += 1
        End While
    End Sub

    Private Function GetClassTotalDonations() As Double
        Dim total As Double = 0
        For Each s As Student In StudentTable
            total += s.GetTotalDonations
        Next
        Return total
    End Function

    Private Sub LoadDonationListBox()
        lstStudentDon.Items.Clear()
        Dim s As Student = cboStudents.SelectedItem
        lstStudentDon.Items.AddRange(s.Donations.ToArray)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim amt As Double
        Dim valid As Boolean = Double.TryParse(TxtDon.Text, amt)
        If valid Then
            Dim s As Student = cboStudents.SelectedItem
            s.Donations.Add(New Donation(amt, Date.Now))
        End If
        UpdateValues()
    End Sub

    Private Sub SaveFile()
        Dim json = JsonConvert.SerializeObject(cboStudents.Items)
        Dim writer = New IO.StreamWriter(strSTUDENTFILE)
        writer.Write(json)
        writer.Close()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        SaveFile()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Dim s As Student = cboStudents.SelectedItem
        Dim d As Donation = lstStudentDon.SelectedItem
        If Not IsNothing(s) AndAlso Not IsNothing(d) Then
            s.Donations.Remove(d)
            UpdateValues()
        End If
    End Sub
End Class

Public Class Student
    Private _name As String
    Private _donations As List(Of Donation)

    Public Sub New(name As String, donations As List(Of Donation))
        Me.Name = name
        Me.Donations = donations
    End Sub

    Public Function GetTotalDonations()
        Dim total As Double = 0
        For Each d As Donation In Donations
            total += d.Amount
        Next
        Return total.ToString("C2")
    End Function
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Donations As List(Of Donation)
        Get
            Return _donations
        End Get
        Set(value As List(Of Donation))
            _donations = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class

Public Class Donation
    Private _amount As Double
    Private _theDate As Date

    Public Property Amount As Double
        Get
            Return _amount
        End Get
        Set(value As Double)
            _amount = value
        End Set
    End Property

    Public Property TheDate As Date
        Get
            Return _theDate
        End Get
        Set(value As Date)
            _theDate = value
        End Set
    End Property

    Public Sub New(amount As Double, theDate As Date)
        Me.Amount = amount
        Me.TheDate = theDate
    End Sub

    Public Overrides Function ToString() As String
        Return Amount.ToString("C2").PadRight(10) & Me.TheDate.ToLocalTime
    End Function
End Class