Public Module homemodule

    Public Sub bring2frontmod()
        'se ocupa de que los botones laterales no queden al fondo luego de cambiar de categoría
        appform.homepanel.BringToFront()
        appform.homebtn.BringToFront()
        appform.appetizerbtn.BringToFront()
        appform.maincoursebtn.BringToFront()
        appform.drinksbtn.BringToFront()
        appform.dessertsbtn.BringToFront()
        appform.orderbtn.BringToFront()

    End Sub

    Public Sub currentscreen()
        'se encarga de hacer el cambio entre pantallas del home
        Select Case homehub.current
            Case 1
                appform.Homehub1.Homescreen11.BringToFront()
                appform.Homehub1.currentplusbtn.BringToFront()
                appform.Homehub1.currentminusbtn.BringToFront()
                appform.Homehub1.Homescreen11.Visible = False
                appform.Homehub1.hhubtransition.ShowSync(appform.Homehub1.Homescreen11)



            Case 2
                appform.Homehub1.Homescreen21.BringToFront()
                appform.Homehub1.currentplusbtn.BringToFront()
                appform.Homehub1.currentminusbtn.BringToFront()
                appform.Homehub1.Homescreen21.Visible = False
                appform.Homehub1.hhubtransition.ShowSync(appform.Homehub1.Homescreen21)


            Case 3
                appform.Homehub1.Homescreen31.BringToFront()
                appform.Homehub1.currentplusbtn.BringToFront()
                appform.Homehub1.currentminusbtn.BringToFront()
                appform.Homehub1.Homescreen31.Visible = False
                appform.Homehub1.hhubtransition.ShowSync(appform.Homehub1.Homescreen31)



        End Select
    End Sub
End Module
