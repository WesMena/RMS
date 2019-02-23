Public Class appform
    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click

        'activa la animación del botón home 
        homebtn.Visible = False
        homebtn.Left = -3
        btnanim.ShowSync(homebtn)
        'trae la pantalla home al frente
        Homehub1.Visible = False
        Homehub1.BringToFront()
        cattransition.ShowSync(Homehub1)
        'ejecuta el método contenido en el módulo homemodule, para evitar que los botones laterales se vayan al fondo
        bring2frontmod()
        'activa la animación del botón nuevamente, para que regrese a su ubicación inicial
        homebtn.Visible = False
        homebtn.Left = -112
        btnanim.ShowSync(homebtn)


    End Sub



    Private Sub appetizerbtn_Click(sender As Object, e As EventArgs) Handles appetizerbtn.Click
        'activa la animación del botón appetizer
        appetizerbtn.Visible = False
        appetizerbtn.Left = -3
        btnanim.ShowSync(appetizerbtn)



        'trae la pantalla appetizer al frente
        AppetizerUC1.Visible = False
        AppetizerUC1.BringToFront()


        cattransition.ShowSync(AppetizerUC1)
        'ejecuta el método contenido en el módulo homemodule, para evitar que los botones laterales se vayan al fondo
        bring2frontmod()
        'activa la animación del botón nuevamente, para que regrese a su ubicación inicial
        appetizerbtn.Visible = False
        appetizerbtn.Left = -112
        btnanim.ShowSync(appetizerbtn)


    End Sub

    Private Sub maincoursebtn_Click(sender As Object, e As EventArgs) Handles maincoursebtn.Click
        'activa la animación del botón main course
        maincoursebtn.Visible = False
            maincoursebtn.Left = -3
        btnanim.ShowSync(maincoursebtn)



        'Trae la pantalla main course al frente
        MaincourseUC1.Visible = False
        MaincourseUC1.BringToFront()


        cattransition.ShowSync(MaincourseUC1)
        'ejecuta el método contenido en el módulo homemodule, para evitar que los botones laterales se vayan al fondo
        bring2frontmod()
        'activa la animación del botón nuevamente, para que regrese a su ubicación inicial
        maincoursebtn.Visible = False
            maincoursebtn.Left = -112
            btnanim.ShowSync(maincoursebtn)


    End Sub

    Private Sub drinksbtn_Click(sender As Object, e As EventArgs) Handles drinksbtn.Click
        'activa la animación del botón drinks
        drinksbtn.Visible = False
            drinksbtn.Left = -3
        btnanim.ShowSync(drinksbtn)


        'Trae la pantalla drinks al frente 
        DrinksUC1.Visible = False
        DrinksUC1.BringToFront()


        cattransition.ShowSync(DrinksUC1)
        'ejecuta el método contenido en el módulo homemodule, para evitar que los botones laterales se vayan al fondo
        bring2frontmod()
        'activa la animación del botón nuevamente, para que regrese a su ubicación inicial
        drinksbtn.Visible = False
            drinksbtn.Left = -112
            btnanim.ShowSync(drinksbtn)


    End Sub

    Private Sub dessertsbtn_Click(sender As Object, e As EventArgs) Handles dessertsbtn.Click
        'activa la animación del botón desserts
        dessertsbtn.Visible = False
            dessertsbtn.Left = -3
        btnanim.ShowSync(dessertsbtn)

        'Trae la pantalla desserts al frente
        DessertsUC1.Visible = False
        DessertsUC1.BringToFront()



        cattransition.ShowSync(DessertsUC1)
        'ejecuta el método contenido en el módulo homemodule, para evitar que los botones laterales se vayan al fondo
        bring2frontmod()
        'activa la animación del botón nuevamente, para que regrese a su ubicación inicial
        dessertsbtn.Visible = False
            dessertsbtn.Left = -112
            btnanim.ShowSync(dessertsbtn)


    End Sub

    Private Sub orderbtn_Click(sender As Object, e As EventArgs) Handles orderbtn.Click
        'activa la animación del botón order
        orderbtn.Visible = False
            orderbtn.Left = -3
        btnanim.ShowSync(orderbtn)



        'falta agregar el uc del pedido'
        Order1.Visible = False
        Order1.BringToFront()
        cattransition.ShowSync(Order1)

        'ejecuta el método contenido en el módulo homemodule, para evitar que los botones laterales se vayan al fondo
        bring2frontmod()


        'activa la animación del botón nuevamente, para que regrese a su ubicación inicial
        orderbtn.Visible = False
            orderbtn.Left = -112
            btnanim.ShowSync(orderbtn)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Homehub1.BringToFront()
        bring2frontmod()

    End Sub

    Private Sub Homehub1_Load(sender As Object, e As EventArgs) Handles Homehub1.Load

    End Sub
End Class
