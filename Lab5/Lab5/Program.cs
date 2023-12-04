using Lab5;

Balloon balloon1 = new Balloon(5);
Balloon balloon2 = new Balloon(2);
Balloon balloon3 = new Balloon(23);
Balloon balloon4 = new Balloon(11);
Balloon balloon5 = new Balloon(435);

Container container = new Container();
container.AddBalloon(balloon1);
container.AddBalloon(balloon2);
container.AddBalloon(balloon3);
container.AddBalloon(balloon4);
container.AddBalloon(balloon5);

Console.WriteLine(container.ToString());

Box box = new Box(5);
box.AddBalloon(balloon1);
box.AddBalloon(balloon2);
box.AddBalloon(balloon3);
box.AddBalloon(balloon4);
box.AddBalloon(balloon5);

Console.WriteLine(box.ToString());

Balloon balloon6 = new Balloon(4545);

box.AddBalloon(balloon6);

Console.WriteLine(box.ToString());