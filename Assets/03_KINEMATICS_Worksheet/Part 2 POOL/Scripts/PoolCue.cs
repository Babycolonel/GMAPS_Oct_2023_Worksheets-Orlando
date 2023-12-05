// using system.collections;
// using system.collections.generic;
// using unityengine;

// public class poolcue : monobehaviour
// {
// 	public linefactory linefactory;
// 	public gameobject ballobject;

// 	private line drawnline;
// 	private ball2d ball;

// 	private void start()
// 	{
// 		ball = ballobject.getcomponent<ball2d>();
// 	}

// 	void update()
// 	{
// 		if (input.getmousebuttondown(0))
// 		{
// 			var startlinepos = camera.main.screentoworldpoint(input.mouseposition); // start line drawing
// 			if (ball != null && ball.iscollidingwith(/*your code here*/))
// 			{
// 				drawnline = /*your code here*/;
// 				drawnline.enabledrawing(true);
// 			}
// 		}
// 		else if (input.getmousebuttonup(0) && drawnline != null)
// 		{
// 			drawnline.enabledrawing(false);

// 			//update the velocity of the white ball.
// 			hvector2d v = new hvector2d(/*your code here*/);
// 			ball./*your code here*/ = v;

// 			drawnline = null; // end line drawing            
// 		}

// 		if (drawnline != null)
// 		{
// 			drawnline.end = /*your code here*/; // update line end
// 		}
// 	}

// 	/// <summary>
// 	/// get a list of active lines and deactivates them.
// 	/// </summary>
// 	public void clear()
// 	{
// 		var activelines = linefactory.getactive();

// 		foreach (var line in activelines)
// 		{
// 			line.gameobject.setactive(false);
// 		}
// 	}
// }
