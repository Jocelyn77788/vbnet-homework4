Imports System
Imports System.Windows.Forms
Imports System.Drawing
Public Class Form1
    Inherits Form
    Private Label1 As Label, menuStrip As MenuStrip
    Private 等级ToolStripMenuItem As ToolStripMenuItem, 帮助ToolStripMenuItem As ToolStripMenuItem
    Private Menu11 As ToolStripMenuItem, Menu12 As ToolStripMenuItem, Menu13 As ToolStripMenuItem, Menu2 As ToolStripMenuItem
    Public Sub New()
        Me.Text = "作业4-5 菜单的使用" : Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle : Me.MaximizeBox = False
        Me.ClientSize = New Size(400, 250)
        menuStrip = New MenuStrip()
        等级ToolStripMenuItem = New ToolStripMenuItem("等级") : 帮助ToolStripMenuItem = New ToolStripMenuItem("帮助")
        Menu11 = New ToolStripMenuItem("等级A") : Menu12 = New ToolStripMenuItem("等级B") : Menu13 = New ToolStripMenuItem("等级C")
        Menu2 = New ToolStripMenuItem("帮助信息")
        AddHandler Menu11.Click, AddressOf Menu11_Click
        AddHandler Menu12.Click, AddressOf Menu12_Click
        AddHandler Menu13.Click, AddressOf Menu13_Click
        AddHandler Menu2.Click, AddressOf Menu2_Click
        等级ToolStripMenuItem.DropDownItems.AddRange(New ToolStripMenuItem() {Menu11, Menu12, Menu13})
        帮助ToolStripMenuItem.DropDownItems.Add(Menu2)
        menuStrip.Items.AddRange(New ToolStripMenuItem() {等级ToolStripMenuItem, 帮助ToolStripMenuItem})
        Me.MainMenuStrip = menuStrip : Controls.Add(menuStrip)
        Label1 = New Label() With {.Left = 100, .Top = 100, .Width = 200, .Height = 30, .TextAlign = ContentAlignment.MiddleCenter, .BorderStyle = BorderStyle.FixedSingle}
        Controls.Add(Label1)
    End Sub
    Private Sub Menu11_Click(sender As Object, e As EventArgs) : Label1.Text = "85分以上" : End Sub
    Private Sub Menu12_Click(sender As Object, e As EventArgs) : Label1.Text = "75分至85分" : End Sub
    Private Sub Menu13_Click(sender As Object, e As EventArgs) : Label1.Text = "60分至75分" : End Sub
    Private Sub Menu2_Click(sender As Object, e As EventArgs) : Label1.Text = "此处显示帮助信息" : End Sub
End Class
Module Module1
    <STAThread()> Sub Main() : Application.EnableVisualStyles() : Application.SetCompatibleTextRenderingDefault(False) : Application.Run(New Form1()) : End Sub
End Module
