using System;
using NamespaceA;
using NamespaceB;
using F=NamespaceA;
//using DGRepCSharp.Replayer; //s a type, not a namespace. 
							//A using namespace directive can only be applied to namespaces.” 

//Note that both the instantiation as the declaration of 'Foo f' needs to be explicitely typed 
//in order to work correctly.
namespace NamespaceExperiment
{
	
	public class CaseTestWrong
	{
		//private Foo f; //compilation error: 'Foo' is an ambiguous reference between NamespaceA.Foo and 
						 //NamespaceB.Foo.
		//private NamespaceA.Foo f; //Same error in constructor.
		
		public CaseTestWrong () 
		{
			//f = new Foo(); //compilation error: 'Foo' is an ambiguous reference between NamespaceA.Foo and 
						 //NamespaceB.Foo.
		}
	}
	
	public class CaseTestSolution
	{
		private NamespaceA.Foo f;
		
		public CaseTestSolution()
		{
			f = new NamespaceA.Foo();
		}
	}
	
	// using F=nsA can shorten a lengthy namespace like System.Net.Sockets to S.
	public class CaseTestSolutionAlternative
	{
		private F.Foo f;
		public CaseTestSolutionAlternative(){
			f = new F.Foo();
		}
	}
	
}

