namespace ClassOOP {
    public interface IPolygon {
        void GetArea();
        void GetPerimeter();
    }

    public class Rectangle : IPolygon {
        public int width;
        public int height;

        public void GetArea()
        {
            throw new NotImplementedException();
        }

        public void GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }

    public class Square : Rectangle {
        public int side;
    }

    public class Point {
        public int x, y;
        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public void Move(int x, int y) {
            this.x += x;
            this.y += y;
        }
        
        public void Print() {
            Console.WriteLine($"x = {x}, y = {y}");
        }
        
        public static Point operator +(Point p1, Point p2) { // operator overloading method for the addition operator + in C#.
            return new Point(p1.x + p2.x, p1.y + p2.y); // cho phép dùng dấu + để cộng 2 điểm
        }
    
    }

    public class Circle : Point {
        public int radius;
        public Point center;

        public Circle(int x, int y, int rad) : base(x, y){
            this.radius = rad;
            this.center = new Point(x, y);
        }
    }


   

    












}