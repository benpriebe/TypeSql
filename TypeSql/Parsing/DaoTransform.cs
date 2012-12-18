//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.4 C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g 2012-12-16 21:08:58

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System;
using System.Linq;
using TypeSql.Parsing;


using System.Collections.Generic;
using TypeSql.Antlr.Runtime;
using TypeSql.Antlr.Runtime.Misc;
using TypeSql.Antlr.Runtime.Tree;
using RewriteRuleITokenStream = TypeSql.Antlr.Runtime.Tree.RewriteRuleTokenStream;

using TypeSql.Antlr3.ST;
using TypeSql.Antlr3.ST.Language;
namespace  TypeSql.Parsing 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.4")]
[System.CLSCompliant(false)]
internal partial class DaoTransform : TypeSql.Antlr.Runtime.Tree.TreeParser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "ANY", "DIGIT", "ID", "INPUT_TOKEN", "NEWLINE", "OUTPUT_TOKEN", "SQL", "WHITESPACE", "':'", "'@'", "'['", "']'"
	};
	public const int EOF=-1;
	public const int T__12=12;
	public const int T__13=13;
	public const int T__14=14;
	public const int T__15=15;
	public const int ANY=4;
	public const int DIGIT=5;
	public const int ID=6;
	public const int INPUT_TOKEN=7;
	public const int NEWLINE=8;
	public const int OUTPUT_TOKEN=9;
	public const int SQL=10;
	public const int WHITESPACE=11;

	public DaoTransform(ITreeNodeStream input)
		: this(input, new RecognizerSharedState())
	{
	}
	public DaoTransform(ITreeNodeStream input, RecognizerSharedState state)
		: base(input, state)
	{
		OnCreated();
	}
	private StringTemplateGroup _templateGroup = new StringTemplateGroup("DaoTransformTemplates", typeof(AngleBracketTemplateLexer) );

	public StringTemplateGroup TemplateGroup
	{
		get { return _templateGroup; }
		set { _templateGroup = value; }
	}

	public override string[] TokenNames { get { return DaoTransform.tokenNames; } }
	public override string GrammarFileName { get { return "C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	partial void EnterRule_sql();
	partial void LeaveRule_sql();

	// $ANTLR start "sql"
	// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:19:8: public sql[string name, string rawSql] : ^( SQL ( outputToken | inputToken | . )* ) -> dao(name=nameoutputTokens=outputTokensinputTokens=inputTokensrawSql=rawSql);
	[GrammarRule("sql")]
	public TemplateTreeRuleReturnScope<StringTemplate, CommonTree> sql(string name, string rawSql)
	{
		EnterRule_sql();
		EnterRule("sql", 1);
		TraceIn("sql", 1);
		TemplateTreeRuleReturnScope<StringTemplate, CommonTree> retval = new TemplateTreeRuleReturnScope<StringTemplate, CommonTree>();
		retval.Start = (CommonTree)input.LT(1);

		DaoTransform.outputToken_return outputToken1 = default(DaoTransform.outputToken_return);
		DaoTransform.inputToken_return inputToken2 = default(DaoTransform.inputToken_return);


			var outputTokens = new List<OutputToken>();
			var inputTokens = new List<InputToken>();

		try { DebugEnterRule(GrammarFileName, "sql");
		DebugLocation(19, 1);
		try
		{
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:24:2: ( ^( SQL ( outputToken | inputToken | . )* ) -> dao(name=nameoutputTokens=outputTokensinputTokens=inputTokensrawSql=rawSql))
			DebugEnterAlt(1);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:24:4: ^( SQL ( outputToken | inputToken | . )* )
			{
			DebugLocation(24, 4);
			DebugLocation(24, 6);
			Match(input,SQL,Follow._SQL_in_sql80); 

			if (input.LA(1) == TokenTypes.Down)
			{
				Match(input, TokenTypes.Down, null); 
				DebugLocation(24, 10);
				// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:24:10: ( outputToken | inputToken | . )*
				try { DebugEnterSubRule(1);
				while (true)
				{
					int alt1=4;
					try { DebugEnterDecision(1, false);
					switch (input.LA(1))
					{
					case OUTPUT_TOKEN:
						{
						int LA1_2 = input.LA(2);

						if ((LA1_2==DOWN))
						{
							int LA1_5 = input.LA(3);

							if ((LA1_5==ID))
							{
								int LA1_7 = input.LA(4);

								if ((LA1_7==ID))
								{
									int LA1_9 = input.LA(5);

									if ((LA1_9==UP))
									{
										alt1 = 1;
									}
									else if (((LA1_9>=ANY && LA1_9<=15)))
									{
										alt1 = 3;
									}


								}
								else if (((LA1_7>=UP && LA1_7<=DIGIT)||(LA1_7>=INPUT_TOKEN && LA1_7<=15)))
								{
									alt1 = 3;
								}


							}
							else if (((LA1_5>=ANY && LA1_5<=DIGIT)||(LA1_5>=INPUT_TOKEN && LA1_5<=15)))
							{
								alt1 = 3;
							}


						}
						else if (((LA1_2>=UP && LA1_2<=15)))
						{
							alt1 = 3;
						}


						}
						break;
					case INPUT_TOKEN:
						{
						int LA1_3 = input.LA(2);

						if ((LA1_3==DOWN))
						{
							int LA1_6 = input.LA(3);

							if ((LA1_6==ID))
							{
								int LA1_8 = input.LA(4);

								if ((LA1_8==ID))
								{
									int LA1_10 = input.LA(5);

									if ((LA1_10==UP))
									{
										alt1 = 2;
									}
									else if (((LA1_10>=ANY && LA1_10<=15)))
									{
										alt1 = 3;
									}


								}
								else if (((LA1_8>=UP && LA1_8<=DIGIT)||(LA1_8>=INPUT_TOKEN && LA1_8<=15)))
								{
									alt1 = 3;
								}


							}
							else if (((LA1_6>=ANY && LA1_6<=DIGIT)||(LA1_6>=INPUT_TOKEN && LA1_6<=15)))
							{
								alt1 = 3;
							}


						}
						else if (((LA1_3>=UP && LA1_3<=15)))
						{
							alt1 = 3;
						}


						}
						break;
					case ANY:
					case DIGIT:
					case ID:
					case NEWLINE:
					case SQL:
					case WHITESPACE:
					case 12:
					case 13:
					case 14:
					case 15:
						{
						alt1 = 3;
						}
						break;
					}

					} finally { DebugExitDecision(1); }
					switch ( alt1 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:25:4: outputToken
						{
						DebugLocation(25, 4);
						PushFollow(Follow._outputToken_in_sql87);
						outputToken1=outputToken();
						PopFollow();

						DebugLocation(25, 16);
						 outputTokens.Add((outputToken1!=null?outputToken1.token:default(OutputToken))); 

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:26:6: inputToken
						{
						DebugLocation(26, 6);
						PushFollow(Follow._inputToken_in_sql97);
						inputToken2=inputToken();
						PopFollow();

						DebugLocation(26, 17);
						 inputTokens.Add((inputToken2!=null?inputToken2.token:default(InputToken))); 

						}
						break;
					case 3:
						DebugEnterAlt(3);
						// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:27:6: .
						{
						DebugLocation(27, 6);
						MatchAny(input); 

						}
						break;

					default:
						goto loop1;
					}
				}

				loop1:
					;

				} finally { DebugExitSubRule(1); }


				Match(input, TokenTypes.Up, null); 
			}


			// TEMPLATE REWRITE
			// 30:3: -> dao(name=nameoutputTokens=outputTokensinputTokens=inputTokensrawSql=rawSql)
			{
				retval.Template = TemplateGroup.GetInstanceOf("dao",
				new Dictionary<string, object>() { {"name", name}, {"outputTokens", outputTokens}, {"inputTokens", inputTokens}, {"rawSql", rawSql} }
			);
			}



			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("sql", 1);
			LeaveRule("sql", 1);
			LeaveRule_sql();
		}
		DebugLocation(31, 1);
		} finally { DebugExitRule(GrammarFileName, "sql"); }
		return retval;

	}
	// $ANTLR end "sql"

	private sealed partial class outputToken_return : TemplateTreeRuleReturnScope<StringTemplate, CommonTree>
	{
		public OutputToken token;
		public outputToken_return(DaoTransform grammar) {OnCreated(grammar);}
		partial void OnCreated(DaoTransform grammar);
	}

	partial void EnterRule_outputToken();
	partial void LeaveRule_outputToken();

	// $ANTLR start "outputToken"
	// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:34:1: outputToken returns [OutputToken token] : ^( OUTPUT_TOKEN id= ID type= ID ) ;
	[GrammarRule("outputToken")]
	private DaoTransform.outputToken_return outputToken()
	{
		EnterRule_outputToken();
		EnterRule("outputToken", 2);
		TraceIn("outputToken", 2);
		DaoTransform.outputToken_return retval = new DaoTransform.outputToken_return(this);
		retval.Start = (CommonTree)input.LT(1);

		CommonTree id = default(CommonTree);
		CommonTree type = default(CommonTree);

		try { DebugEnterRule(GrammarFileName, "outputToken");
		DebugLocation(34, 1);
		try
		{
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:35:2: ( ^( OUTPUT_TOKEN id= ID type= ID ) )
			DebugEnterAlt(1);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:35:4: ^( OUTPUT_TOKEN id= ID type= ID )
			{
			DebugLocation(35, 4);
			DebugLocation(35, 6);
			Match(input,OUTPUT_TOKEN,Follow._OUTPUT_TOKEN_in_outputToken162); 

			Match(input, TokenTypes.Down, null); 
			DebugLocation(35, 21);
			id=(CommonTree)Match(input,ID,Follow._ID_in_outputToken166); 
			DebugLocation(35, 29);
			type=(CommonTree)Match(input,ID,Follow._ID_in_outputToken170); 

			Match(input, TokenTypes.Up, null); 

			DebugLocation(35, 36);
			 retval.token = new OutputToken((id!=null?id.Text:null), (type!=null?type.Text:null)); 

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("outputToken", 2);
			LeaveRule("outputToken", 2);
			LeaveRule_outputToken();
		}
		DebugLocation(36, 1);
		} finally { DebugExitRule(GrammarFileName, "outputToken"); }
		return retval;

	}
	// $ANTLR end "outputToken"

	private sealed partial class inputToken_return : TemplateTreeRuleReturnScope<StringTemplate, CommonTree>
	{
		public InputToken token;
		public inputToken_return(DaoTransform grammar) {OnCreated(grammar);}
		partial void OnCreated(DaoTransform grammar);
	}

	partial void EnterRule_inputToken();
	partial void LeaveRule_inputToken();

	// $ANTLR start "inputToken"
	// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:38:1: inputToken returns [InputToken token] : ^( INPUT_TOKEN id= ID type= ID ) ;
	[GrammarRule("inputToken")]
	private DaoTransform.inputToken_return inputToken()
	{
		EnterRule_inputToken();
		EnterRule("inputToken", 3);
		TraceIn("inputToken", 3);
		DaoTransform.inputToken_return retval = new DaoTransform.inputToken_return(this);
		retval.Start = (CommonTree)input.LT(1);

		CommonTree id = default(CommonTree);
		CommonTree type = default(CommonTree);

		try { DebugEnterRule(GrammarFileName, "inputToken");
		DebugLocation(38, 1);
		try
		{
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:39:2: ( ^( INPUT_TOKEN id= ID type= ID ) )
			DebugEnterAlt(1);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:39:4: ^( INPUT_TOKEN id= ID type= ID )
			{
			DebugLocation(39, 4);
			DebugLocation(39, 6);
			Match(input,INPUT_TOKEN,Follow._INPUT_TOKEN_in_inputToken191); 

			Match(input, TokenTypes.Down, null); 
			DebugLocation(39, 20);
			id=(CommonTree)Match(input,ID,Follow._ID_in_inputToken195); 
			DebugLocation(39, 28);
			type=(CommonTree)Match(input,ID,Follow._ID_in_inputToken199); 

			Match(input, TokenTypes.Up, null); 

			DebugLocation(39, 35);
			 retval.token = new InputToken((id!=null?id.Text:null), (type!=null?type.Text:null)); 

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("inputToken", 3);
			LeaveRule("inputToken", 3);
			LeaveRule_inputToken();
		}
		DebugLocation(40, 1);
		} finally { DebugExitRule(GrammarFileName, "inputToken"); }
		return retval;

	}
	// $ANTLR end "inputToken"
	#endregion Rules


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _SQL_in_sql80 = new BitSet(new ulong[]{0x4UL});
		public static readonly BitSet _outputToken_in_sql87 = new BitSet(new ulong[]{0xFFF8UL});
		public static readonly BitSet _inputToken_in_sql97 = new BitSet(new ulong[]{0xFFF8UL});
		public static readonly BitSet _OUTPUT_TOKEN_in_outputToken162 = new BitSet(new ulong[]{0x4UL});
		public static readonly BitSet _ID_in_outputToken166 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _ID_in_outputToken170 = new BitSet(new ulong[]{0x8UL});
		public static readonly BitSet _INPUT_TOKEN_in_inputToken191 = new BitSet(new ulong[]{0x4UL});
		public static readonly BitSet _ID_in_inputToken195 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _ID_in_inputToken199 = new BitSet(new ulong[]{0x8UL});
	}
	#endregion Follow sets
}

} // namespace  TypeSql.Parsing 