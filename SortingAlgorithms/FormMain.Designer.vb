<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.Index = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumberOfItem = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnFillRandom = New System.Windows.Forms.Button()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RadioButtonLess = New System.Windows.Forms.RadioButton()
        Me.RadioButtonGreater = New System.Windows.Forms.RadioButton()
        Me.btnBinaryInsertionSort = New System.Windows.Forms.Button()
        Me.btnInsertionSort = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxCountOFCompare = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Index, Me.Item})
        Me.DataGridView.Location = New System.Drawing.Point(93, 88)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowTemplate.Height = 28
        Me.DataGridView.Size = New System.Drawing.Size(381, 669)
        Me.DataGridView.TabIndex = 0
        '
        'Index
        '
        Me.Index.HeaderText = "Index"
        Me.Index.Name = "Index"
        '
        'Item
        '
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNumberOfItem)
        Me.Panel1.Location = New System.Drawing.Point(545, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(655, 87)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Количество элементов в массиве"
        '
        'txtNumberOfItem
        '
        Me.txtNumberOfItem.Location = New System.Drawing.Point(349, 26)
        Me.txtNumberOfItem.Name = "txtNumberOfItem"
        Me.txtNumberOfItem.Size = New System.Drawing.Size(58, 26)
        Me.txtNumberOfItem.TabIndex = 0
        Me.txtNumberOfItem.Text = "10"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnFillRandom)
        Me.Panel2.Controls.Add(Me.txtMax)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtMin)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(542, 205)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(661, 205)
        Me.Panel2.TabIndex = 2
        '
        'btnFillRandom
        '
        Me.btnFillRandom.Location = New System.Drawing.Point(373, 65)
        Me.btnFillRandom.Name = "btnFillRandom"
        Me.btnFillRandom.Size = New System.Drawing.Size(180, 89)
        Me.btnFillRandom.TabIndex = 4
        Me.btnFillRandom.Text = "Заполнить случайными числами"
        Me.btnFillRandom.UseVisualStyleBackColor = True
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(238, 121)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(56, 26)
        Me.txtMax.TabIndex = 3
        Me.txtMax.Text = "100"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Верхняя граница"
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(238, 65)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(56, 26)
        Me.txtMin.TabIndex = 1
        Me.txtMin.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Нижняя граница"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RadioButtonLess)
        Me.Panel3.Controls.Add(Me.RadioButtonGreater)
        Me.Panel3.Controls.Add(Me.btnBinaryInsertionSort)
        Me.Panel3.Controls.Add(Me.btnInsertionSort)
        Me.Panel3.Location = New System.Drawing.Point(544, 425)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(659, 167)
        Me.Panel3.TabIndex = 3
        '
        'RadioButtonLess
        '
        Me.RadioButtonLess.AutoSize = True
        Me.RadioButtonLess.Location = New System.Drawing.Point(30, 90)
        Me.RadioButtonLess.Name = "RadioButtonLess"
        Me.RadioButtonLess.Size = New System.Drawing.Size(134, 24)
        Me.RadioButtonLess.TabIndex = 3
        Me.RadioButtonLess.Text = "По убыванию"
        Me.RadioButtonLess.UseVisualStyleBackColor = True
        '
        'RadioButtonGreater
        '
        Me.RadioButtonGreater.AutoSize = True
        Me.RadioButtonGreater.Checked = True
        Me.RadioButtonGreater.Location = New System.Drawing.Point(30, 51)
        Me.RadioButtonGreater.Name = "RadioButtonGreater"
        Me.RadioButtonGreater.Size = New System.Drawing.Size(159, 24)
        Me.RadioButtonGreater.TabIndex = 2
        Me.RadioButtonGreater.TabStop = True
        Me.RadioButtonGreater.Text = "По возрастанию"
        Me.RadioButtonGreater.UseVisualStyleBackColor = True
        '
        'btnBinaryInsertionSort
        '
        Me.btnBinaryInsertionSort.Location = New System.Drawing.Point(236, 51)
        Me.btnBinaryInsertionSort.Name = "btnBinaryInsertionSort"
        Me.btnBinaryInsertionSort.Size = New System.Drawing.Size(198, 89)
        Me.btnBinaryInsertionSort.TabIndex = 1
        Me.btnBinaryInsertionSort.Text = "Сортировка вставками с бинарным поиском"
        Me.btnBinaryInsertionSort.UseVisualStyleBackColor = True
        '
        'btnInsertionSort
        '
        Me.btnInsertionSort.Location = New System.Drawing.Point(464, 51)
        Me.btnInsertionSort.Name = "btnInsertionSort"
        Me.btnInsertionSort.Size = New System.Drawing.Size(126, 89)
        Me.btnInsertionSort.TabIndex = 0
        Me.btnInsertionSort.Text = "Сортировка вставками"
        Me.btnInsertionSort.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TextBoxCountOFCompare)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(542, 611)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(661, 117)
        Me.Panel4.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Количество сравнений"
        '
        'TextBoxCountOFCompare
        '
        Me.TextBoxCountOFCompare.Location = New System.Drawing.Point(232, 37)
        Me.TextBoxCountOFCompare.Name = "TextBoxCountOFCompare"
        Me.TextBoxCountOFCompare.Size = New System.Drawing.Size(77, 26)
        Me.TextBoxCountOFCompare.TabIndex = 1
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1758, 806)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView)
        Me.Name = "FormMain"
        Me.Text = "Form1"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumberOfItem As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnFillRandom As Button
    Friend WithEvents txtMax As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnBinaryInsertionSort As Button
    Friend WithEvents btnInsertionSort As Button
    Friend WithEvents Index As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents RadioButtonLess As RadioButton
    Friend WithEvents RadioButtonGreater As RadioButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBoxCountOFCompare As TextBox
    Friend WithEvents Label4 As Label
End Class
