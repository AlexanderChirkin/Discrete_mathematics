<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNumberOfItem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.btnFillRandom = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnInsertionSort = New System.Windows.Forms.Button()
        Me.btnBinaryInsertionSort = New System.Windows.Forms.Button()
        Me.Index = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNumberOfItem)
        Me.Panel1.Location = New System.Drawing.Point(486, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(655, 104)
        Me.Panel1.TabIndex = 1
        '
        'txtNumberOfItem
        '
        Me.txtNumberOfItem.Location = New System.Drawing.Point(349, 26)
        Me.txtNumberOfItem.Name = "txtNumberOfItem"
        Me.txtNumberOfItem.Size = New System.Drawing.Size(58, 26)
        Me.txtNumberOfItem.TabIndex = 0
        Me.txtNumberOfItem.Text = "10"
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnFillRandom)
        Me.Panel2.Controls.Add(Me.txtMax)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtMin)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(480, 215)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(661, 205)
        Me.Panel2.TabIndex = 2
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
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(238, 65)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(56, 26)
        Me.txtMin.TabIndex = 1
        Me.txtMin.Text = "1"
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
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(238, 121)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(56, 26)
        Me.txtMax.TabIndex = 3
        Me.txtMax.Text = "100"
        '
        'btnFillRandom
        '
        Me.btnFillRandom.Location = New System.Drawing.Point(399, 65)
        Me.btnFillRandom.Name = "btnFillRandom"
        Me.btnFillRandom.Size = New System.Drawing.Size(180, 89)
        Me.btnFillRandom.TabIndex = 4
        Me.btnFillRandom.Text = "Заполнить случайными числами"
        Me.btnFillRandom.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnBinaryInsertionSort)
        Me.Panel3.Controls.Add(Me.btnInsertionSort)
        Me.Panel3.Location = New System.Drawing.Point(482, 495)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(659, 167)
        Me.Panel3.TabIndex = 3
        '
        'btnInsertionSort
        '
        Me.btnInsertionSort.Location = New System.Drawing.Point(467, 58)
        Me.btnInsertionSort.Name = "btnInsertionSort"
        Me.btnInsertionSort.Size = New System.Drawing.Size(126, 63)
        Me.btnInsertionSort.TabIndex = 0
        Me.btnInsertionSort.Text = "Сортировка вставками"
        Me.btnInsertionSort.UseVisualStyleBackColor = True
        '
        'btnBinaryInsertionSort
        '
        Me.btnBinaryInsertionSort.Location = New System.Drawing.Point(195, 54)
        Me.btnBinaryInsertionSort.Name = "btnBinaryInsertionSort"
        Me.btnBinaryInsertionSort.Size = New System.Drawing.Size(198, 70)
        Me.btnBinaryInsertionSort.TabIndex = 1
        Me.btnBinaryInsertionSort.Text = "Сортировка вставками с бинарным поиском"
        Me.btnBinaryInsertionSort.UseVisualStyleBackColor = True
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1758, 806)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
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
End Class
