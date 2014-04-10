Public Class clsSecurity
    'Instance Variables

    Public m_KeyDigit, m_CharASCII, m_KeyNum, m_key(4) As Integer
    Public m_CurrentChar, m_CharOutput, m_KeyString As String

    Public Property KeyNum() As Integer
        Get
            Return m_KeyNum
        End Get
        Set(ByVal Value As Integer)
            m_KeyNum = Value
        End Set
    End Property

    Public Property KeyString() As String
        Get
            Return m_KeyString
        End Get
        Set(ByVal Value As String)
            m_KeyString = Value
        End Set
    End Property
    Public Property CurrentChar() As String
        Get
            Return m_CurrentChar
        End Get
        Set(ByVal Value As String)
            m_CurrentChar = Value
        End Set
    End Property

    Public Property CharOutput() As String
        Get
            Return m_CharOutput
        End Get
        Set(ByVal Value As String)
            m_CharOutput = Value
        End Set
    End Property

    Public Property KeyDigit() As Integer
        Get
            Return m_KeyDigit
        End Get
        Set(ByVal Value As Integer)
            m_KeyDigit = Value
        End Set
    End Property
    Public Property charASCII() As Integer
        Get
            Return m_CharASCII
        End Get
        Set(ByVal Value As Integer)
            m_CharASCII = Value
        End Set
    End Property
  
    Public Function Encrypt(ByVal passedarg As String) As String
        Dim i As Integer = Nothing

        Try
            For i = 0 To 4
                m_key(i) = m_KeyString.Substring(i, 1)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        m_CharASCII = Asc(m_CurrentChar) + m_key(m_KeyDigit)

        If m_CharASCII > 126 Then
            m_CharASCII = m_CharASCII - 95
        End If
        Return m_CharASCII
    End Function

    Public Function Decrypt(ByVal Cleartext As String) As String
        Dim i As Integer = Nothing

        Try
            For i = 0 To 4
                m_key(i) = m_KeyString.Substring(i, 1)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        m_CharASCII = Asc(m_CurrentChar) - m_key(m_KeyDigit)

        If m_CharASCII > 126 Then
            m_CharASCII = m_CharASCII - 95
        End If
        Return m_CharASCII
    End Function

End Class