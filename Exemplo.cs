using System.Drawing;
using System.Windows.Forms;
 
public class ExampleApp : App
{

    public List<Machine> machines = new List<Machine>();
    public int Turno = 0;
    bool fundiu = false;
    bool clicked = false;

    RectangleF rect1 = RectangleF.Empty;
    RectangleF rect2 = RectangleF.Empty;
    RectangleF rect3 = RectangleF.Empty;
    RectangleF rect4 = RectangleF.Empty;
    RectangleF rect5 = RectangleF.Empty;
    RectangleF rect6 = RectangleF.Empty;
    RectangleF rect7 = RectangleF.Empty;
    RectangleF rect8 = RectangleF.Empty;
    RectangleF rect9 = RectangleF.Empty;
    RectangleF rect10 = RectangleF.Empty;
    RectangleF rect11 = RectangleF.Empty;
    RectangleF rect12 = RectangleF.Empty;
    RectangleF rect13 = RectangleF.Empty;
    
    public override void OnFrame(bool isDown, PointF cursor)
    {

        if (rect1.Contains(cursor) && rect2.Contains(cursor) && !isDown)
            fundiu = true;
 
        if (!fundiu)
        {
            rect1 = DrawPiece(new RectangleF(50, 600, 200, 200), 1, 3, 1, 1, true, "CNC");
            rect2 = DrawPiece(new RectangleF(250, 600, 200, 200), 2, 4, 2, 1, true, "CNC");
            rect3 = DrawPiece(new RectangleF(450, 600, 200, 200), 2, 4, 2, 1, true, "CNC");
            rect4 = DrawPiece(new RectangleF(650, 600, 200, 200), 2, 4, 2, 1, true, "CNC");
            rect5 = DrawPiece(new RectangleF(850, 600, 200, 200), 2, 4, 2, 1, true, "CNC");
            rect4 = DrawPiece(new RectangleF(650, 600, 200, 200), 2, 4, 2, 1, true, "CNC");
            rect5 = DrawPiece(new RectangleF(850, 600, 200, 200), 2, 4, 2, 1, true, "CNC");
            rect6 = DrawPiece(new RectangleF(1050, 600, 200, 200), 2, 4, 2, 1, true, "Extra");
            rect7 = DrawPiece(new RectangleF(1250, 600, 200, 200), 2, 4, 2, 1, true, "Extra");
            rect8 = DrawPiece(new RectangleF(1450, 600, 200, 200), 2, 4, 2, 1, true, "Comida");
            rect9 = DrawPiece(new RectangleF(200, 300, 200, 200), 2, 4, 2, 1, true, "Time1");
            rect10 = DrawPiece(new RectangleF(400, 300, 200, 200), 2, 4, 2, 1, true, "Time2");
            rect11 = DrawPiece(new RectangleF(600, 300, 200, 200), 2, 4, 2, 1, true, "Time3");
            rect12 = DrawPiece(new RectangleF(800, 300, 200, 200), 2, 4, 2, 1, true, "Time4");
            rect13 = DrawPiece(new RectangleF(1000, 300, 200, 200), 2, 4, 2, 1, true, "Time5");


        }
        else
        {
            DrawPiece(new RectangleF(50, 50, 200, 200), 3, 5, 3, 1, true, "CNC");
        }
 
        if (!clicked)
        {
            clicked = DrawButton(new RectangleF(1650, 900, 200, 100), "Iniciar");
            if (clicked)
                MessageBox.Show("Iniciar Game");
        }
        
    }
}
