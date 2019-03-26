using System;


namespace FrogJumps
{
	public class FrogJump
	{
		static void Main(string [] args)
		{
			int metersToJump=Int32.Parse(Console.ReadLine());
			Console.WriteLine(CalculateJumps(metersToJump));
		
		}

		public static string CalculateJumps(int metersToJump)
		{
			Frog frog=new Frog();
			int hopsCounts=0;
			int restTimes=0;
			
			while(metersToJump>0)
			{
				if(metersToJump<5)
				{
					hopsCounts++;
					metersToJump-=metersToJump;	
				}

				if(metersToJump>=5)
				{
					if(metersToJump==5)
					{
						hopsCounts++;
						metersToJump-=5;
					}
					else
					{
						hopsCounts++;
						restTimes+=2;
						metersToJump-=5;
					}
					
					
					if(metersToJump>=3)
					{
						if(metersToJump==3)
						{
							hopsCounts++;
							metersToJump-=3;
						}
						else
						{
							hopsCounts++;
							restTimes+=3;
							metersToJump-=3;
						}
							
					}
					
					if(metersToJump>=2)
					{
						if(metersToJump==2)
						{
							hopsCounts++;
							metersToJump-=2;
						}
						else
						{
							hopsCounts++;
							restTimes+=5;
							metersToJump-=2;
						}
						
					}
							
				}
			}
			
			frog.HopsCount=hopsCounts;
			frog.RestTime=restTimes;
			
				
			
			return frog.ToString();
			
		}

	
	}


	class Frog
	{
		public int HopsCount{get;set;}
	
		public int RestTime{get;set;}

	
		public override string ToString()
		{
			return $"{HopsCount} Hops and {RestTime}s Rest Time";
		}
	}
}
