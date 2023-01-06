namespace Drawing;

public class Rectangle{

public Point StartPoint{get; set;}
public Point EndPoint{get; set;}

public Rectangle(){
    this.StartPoint=new Point(0,0);
    this.EndPoint=new Point(0,0);
}

public Rectangle(Point start,Point end){
    this.StartPoint=start;
    this.EndPoint=end;
}
public override ToString(){
    
}



}