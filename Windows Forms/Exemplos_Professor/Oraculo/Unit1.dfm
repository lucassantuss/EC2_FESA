object Form1: TForm1
  Left = 152
  Top = 129
  Width = 553
  Height = 429
  Caption = 'Or'#225'culo'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 24
    Top = 32
    Width = 43
    Height = 13
    Caption = 'Pergunta'
  end
  object Edit1: TEdit
    Left = 24
    Top = 48
    Width = 497
    Height = 21
    TabOrder = 0
    OnKeyPress = Edit1KeyPress
  end
  object Button2: TButton
    Left = 24
    Top = 72
    Width = 75
    Height = 25
    Caption = 'Resposta'
    TabOrder = 1
    OnClick = Button2Click
  end
end
