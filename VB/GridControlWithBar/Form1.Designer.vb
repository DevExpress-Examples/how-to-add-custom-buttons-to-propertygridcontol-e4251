﻿Imports Microsoft.VisualBasic
Imports System
Namespace GridControlWithBar
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.propertyGridControlDescendant1 = New GridControlWithBar.PropertyGridControlDescendant()
			CType(Me.propertyGridControlDescendant1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' propertyGridControlDescendant1
			' 
			Me.propertyGridControlDescendant1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyGridControlDescendant1.Location = New System.Drawing.Point(0, 0)
			Me.propertyGridControlDescendant1.Name = "propertyGridControlDescendant1"
			Me.propertyGridControlDescendant1.Size = New System.Drawing.Size(703, 442)
			Me.propertyGridControlDescendant1.TabIndex = 0
			Me.propertyGridControlDescendant1.Tag = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(703, 442)
			Me.Controls.Add(Me.propertyGridControlDescendant1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.propertyGridControlDescendant1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private propertyGridControlDescendant1 As PropertyGridControlDescendant









	End Class
End Namespace

