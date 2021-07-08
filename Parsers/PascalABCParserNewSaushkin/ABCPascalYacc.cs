// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.3.6
// Machine:  DESKTOP-G8V08V4
// DateTime: 06.07.2021 21:55:28
// UserName: ?????????
// Input file <D:\PABC_Git\Parsers\PascalABCParserNewSaushkin\ABCPascal.y>

// options: no-lines gplex

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using QUT.Gppg;
using PascalABCCompiler.SyntaxTree;
using PascalABCSavParser;
using PascalABCCompiler.ParserTools;
using PascalABCCompiler.Errors;
using System.Linq;
using SyntaxVisitors;

namespace GPPGParserScanner
{
public enum Tokens {
    error=1,EOF=2,tkDirectiveName=3,tkAmpersend=4,tkColon=5,tkDotDot=6,
    tkPoint=7,tkRoundOpen=8,tkRoundClose=9,tkSemiColon=10,tkSquareOpen=11,tkSquareClose=12,
    tkQuestion=13,tkUnderscore=14,tkQuestionPoint=15,tkDoubleQuestion=16,tkQuestionSquareOpen=17,tkBackSlashRoundOpen=18,
    tkSizeOf=19,tkTypeOf=20,tkWhere=21,tkArray=22,tkCase=23,tkClass=24,
    tkAuto=25,tkStatic=26,tkConst=27,tkConstructor=28,tkDestructor=29,tkElse=30,
    tkExcept=31,tkFile=32,tkFor=33,tkForeach=34,tkFunction=35,tkMatch=36,
    tkWhen=37,tkIf=38,tkImplementation=39,tkInherited=40,tkInterface=41,tkProcedure=42,
    tkOperator=43,tkProperty=44,tkRaise=45,tkRecord=46,tkSet=47,tkType=48,
    tkThen=49,tkUses=50,tkVar=51,tkWhile=52,tkWith=53,tkNil=54,
    tkGoto=55,tkOf=56,tkLabel=57,tkLock=58,tkProgram=59,tkEvent=60,
    tkDefault=61,tkTemplate=62,tkPacked=63,tkExports=64,tkResourceString=65,tkThreadvar=66,
    tkSealed=67,tkPartial=68,tkTo=69,tkDownto=70,tkLoop=71,tkSequence=72,
    tkYield=73,tkShortProgram=74,tkVertParen=75,tkShortSFProgram=76,tkNew=77,tkOn=78,
    tkName=79,tkPrivate=80,tkProtected=81,tkPublic=82,tkInternal=83,tkRead=84,
    tkWrite=85,tkParseModeExpression=86,tkParseModeStatement=87,tkParseModeType=88,tkBegin=89,tkEnd=90,
    tkAsmBody=91,tkILCode=92,tkError=93,INVISIBLE=94,tkRepeat=95,tkUntil=96,
    tkDo=97,tkComma=98,tkFinally=99,tkTry=100,tkInitialization=101,tkFinalization=102,
    tkUnit=103,tkLibrary=104,tkExternal=105,tkParams=106,tkNamespace=107,tkAssign=108,
    tkPlusEqual=109,tkMinusEqual=110,tkMultEqual=111,tkDivEqual=112,tkMinus=113,tkPlus=114,
    tkSlash=115,tkStar=116,tkStarStar=117,tkEqual=118,tkGreater=119,tkGreaterEqual=120,
    tkLower=121,tkLowerEqual=122,tkNotEqual=123,tkCSharpStyleOr=124,tkArrow=125,tkOr=126,
    tkXor=127,tkAnd=128,tkDiv=129,tkMod=130,tkShl=131,tkShr=132,
    tkNot=133,tkAs=134,tkIn=135,tkIs=136,tkImplicit=137,tkExplicit=138,
    tkAddressOf=139,tkDeref=140,tkIdentifier=141,tkStringLiteral=142,tkFormatStringLiteral=143,tkAsciiChar=144,
    tkAbstract=145,tkForward=146,tkOverload=147,tkReintroduce=148,tkOverride=149,tkVirtual=150,
    tkExtensionMethod=151,tkInteger=152,tkBigInteger=153,tkFloat=154,tkHex=155,tkUnknown=156};

// Abstract base class for GPLEX scanners
public abstract class ScanBase : AbstractScanner<PascalABCSavParser.Union,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

public partial class GPPGParser: ShiftReduceParser<PascalABCSavParser.Union, LexLocation>
{
  // Verbatim content from D:\PABC_Git\Parsers\PascalABCParserNewSaushkin\ABCPascal.y
// ��� ���������� ����������� � ����� GPPGParser, �������������� ����� ������, ������������ �������� gppg
    public syntax_tree_node root; // �������� ���� ��������������� ������ 

    public List<Error> errors;
    public string current_file_name;
    public int max_errors = 10;
    public PT parsertools;
    public List<compiler_directive> CompilerDirectives;
	public ParserLambdaHelper lambdaHelper = new ParserLambdaHelper();
	
    public GPPGParser(AbstractScanner<PascalABCSavParser.Union, LexLocation> scanner) : base(scanner) { }
  // End verbatim content from D:\PABC_Git\Parsers\PascalABCParserNewSaushkin\ABCPascal.y

#pragma warning disable 649
  private static Dictionary<int, string> aliasses;
#pragma warning restore 649
  private static Rule[] rules = new Rule[1005];
  private static State[] states = new State[1666];
  private static string[] nonTerms = new string[] {
      "parse_goal", "unit_key_word", "class_or_static", "assignment", "optional_array_initializer", 
      "attribute_declarations", "ot_visibility_specifier", "one_attribute", "attribute_variable", 
      "const_factor", "const_factor_without_unary_op", "const_variable_2", "const_term", 
      "const_variable", "literal_or_number", "unsigned_number", "variable_or_literal_or_number", 
      "program_block", "optional_var", "class_attribute", "class_attributes", 
      "class_attributes1", "lambda_unpacked_params_or_id", "lambda_list_of_unpacked_params_or_id", 
      "member_list_section", "optional_component_list_seq_end", "const_decl", 
      "only_const_decl", "const_decl_sect", "object_type", "record_type", "member_list", 
      "method_decl_list", "field_or_const_definition_list", "case_stmt", "case_list", 
      "program_decl_sect_list", "int_decl_sect_list1", "inclass_decl_sect_list1", 
      "interface_decl_sect_list", "decl_sect_list", "decl_sect_list1", "inclass_decl_sect_list", 
      "decl_sect_list_proc_func_only", "field_or_const_definition", "abc_decl_sect", 
      "decl_sect", "int_decl_sect", "type_decl", "simple_type_decl", "simple_field_or_const_definition", 
      "res_str_decl_sect", "method_decl_withattr", "method_or_property_decl", 
      "property_definition", "fp_sect", "default_expr", "tuple", "expr_as_stmt", 
      "exception_block", "external_block", "exception_handler", "exception_handler_list", 
      "exception_identifier", "typed_const_list1", "typed_const_list", "optional_expr_list", 
      "elem_list", "optional_expr_list_with_bracket", "expr_list", "const_elem_list1", 
      "case_label_list", "const_elem_list", "optional_const_func_expr_list", 
      "elem_list1", "enumeration_id", "expr_l1_or_unpacked_list", "enumeration_id_list", 
      "const_simple_expr", "term", "term1", "typed_const", "typed_const_plus", 
      "typed_var_init_expression", "expr", "expr_with_func_decl_lambda", "const_expr", 
      "const_relop_expr", "elem", "range_expr", "const_elem", "array_const", 
      "factor", "factor_without_unary_op", "relop_expr", "expr_dq", "lambda_unpacked_params", 
      "expr_l1", "expr_l1_or_unpacked", "expr_l1_func_decl_lambda", "expr_l1_for_lambda", 
      "simple_expr", "range_term", "range_factor", "external_directive_ident", 
      "init_const_expr", "case_label", "variable", "var_reference", "optional_read_expr", 
      "simple_expr_or_nothing", "var_question_point", "expr_l1_for_question_expr", 
      "expr_l1_for_new_question_expr", "for_cycle_type", "format_expr", "format_const_expr", 
      "const_expr_or_nothing", "foreach_stmt", "for_stmt", "loop_stmt", "yield_stmt", 
      "yield_sequence_stmt", "fp_list", "fp_sect_list", "file_type", "sequence_type", 
      "var_address", "goto_stmt", "func_name_ident", "param_name", "const_field_name", 
      "func_name_with_template_args", "identifier_or_keyword", "unit_name", "exception_variable", 
      "const_name", "func_meth_name_ident", "label_name", "type_decl_identifier", 
      "template_identifier_with_equal", "program_param", "identifier", "identifier_keyword_operatorname", 
      "func_class_name_ident", "visibility_specifier", "property_specifier_directives", 
      "non_reserved", "if_stmt", "initialization_part", "template_arguments", 
      "label_list", "ident_or_keyword_pointseparator_list", "ident_list", "param_name_list", 
      "inherited_message", "implementation_part", "interface_part", "abc_interface_part", 
      "simple_type_list", "literal", "one_literal", "literal_list", "label_decl_sect", 
      "lock_stmt", "func_name", "proc_name", "optional_proc_name", "new_expr", 
      "allowable_expr_as_stmt", "parts", "inclass_block", "block", "proc_func_external_block", 
      "exception_class_type_identifier", "simple_type_identifier", "base_class_name", 
      "base_classes_names_list", "optional_base_classes", "one_compiler_directive", 
      "optional_head_compiler_directives", "head_compiler_directives", "program_heading_2", 
      "optional_tk_point", "program_param_list", "optional_semicolon", "operator_name_ident", 
      "const_relop", "const_addop", "assign_operator", "const_mulop", "relop", 
      "addop", "mulop", "sign", "overload_operator", "typecast_op", "property_specifiers", 
      "write_property_specifiers", "read_property_specifiers", "array_defaultproperty", 
      "meth_modificators", "optional_method_modificators", "optional_method_modificators1", 
      "meth_modificator", "property_modificator", "optional_property_initialization", 
      "proc_call", "proc_func_constr_destr_decl", "proc_func_decl", "inclass_proc_func_decl", 
      "inclass_proc_func_decl_noclass", "constr_destr_decl", "inclass_constr_destr_decl", 
      "method_decl", "proc_func_constr_destr_decl_with_attr", "proc_func_decl_noclass", 
      "method_header", "proc_type_decl", "procedural_type_kind", "proc_header", 
      "procedural_type", "constr_destr_header", "proc_func_header", "func_header", 
      "method_procfunc_header", "int_func_header", "int_proc_header", "property_interface", 
      "program_file", "program_header", "parameter_decl", "parameter_decl_list", 
      "property_parameter_list", "const_set", "question_expr", "question_constexpr", 
      "new_question_expr", "record_const", "const_field_list_1", "const_field_list", 
      "const_field", "repeat_stmt", "raise_stmt", "pointer_type", "attribute_declaration", 
      "one_or_some_attribute", "stmt_list", "else_case", "exception_block_else_branch", 
      "compound_stmt", "string_type", "sizeof_expr", "simple_property_definition", 
      "stmt_or_expression", "unlabelled_stmt", "stmt", "case_item", "set_type", 
      "as_is_expr", "as_is_constexpr", "is_type_expr", "as_expr", "power_expr", 
      "power_constexpr", "unsized_array_type", "simple_type_or_", "simple_type", 
      "simple_type_question", "foreach_stmt_ident_dype_opt", "fptype", "type_ref", 
      "fptype_noproctype", "array_type", "template_param", "template_empty_param", 
      "structured_type", "unpacked_structured_type", "empty_template_type_reference", 
      "simple_or_template_type_reference", "type_ref_or_secific", "for_stmt_decl_or_assign", 
      "type_decl_type", "type_ref_and_secific_list", "type_decl_sect", "try_handler", 
      "class_or_interface_keyword", "optional_tk_do", "keyword", "reserved_keyword", 
      "typeof_expr", "simple_fp_sect", "template_param_list", "template_empty_param_list", 
      "template_type_params", "template_type_empty_params", "template_type", 
      "try_stmt", "uses_clause", "used_units_list", "uses_clause_one", "uses_clause_one_or_empty", 
      "unit_file", "used_unit_name", "unit_header", "var_decl_sect", "var_decl", 
      "var_decl_part", "field_definition", "var_decl_with_assign_var_tuple", 
      "var_stmt", "where_part", "where_part_list", "optional_where_section", 
      "while_stmt", "with_stmt", "variable_as_type", "dotted_identifier", "func_decl_lambda", 
      "expl_func_decl_lambda", "lambda_type_ref", "lambda_type_ref_noproctype", 
      "full_lambda_fp_list", "lambda_simple_fp_sect", "lambda_function_body", 
      "lambda_procedure_body", "common_lambda_body", "optional_full_lambda_fp_list", 
      "field_in_unnamed_object", "list_fields_in_unnamed_object", "func_class_name_ident_list", 
      "rem_lambda", "variable_list", "var_ident_list", "tkAssignOrEqual", "const_pattern_expression", 
      "pattern", "deconstruction_or_const_pattern", "pattern_optional_var", "collection_pattern", 
      "tuple_pattern", "collection_pattern_list_item", "tuple_pattern_item", 
      "collection_pattern_var_item", "match_with", "pattern_case", "pattern_cases", 
      "pattern_out_param", "pattern_out_param_optional_var", "pattern_out_param_list", 
      "pattern_out_param_list_optional_var", "collection_pattern_expr_list", 
      "tuple_pattern_item_list", "const_pattern_expr_list", "var_with_init_for_expr_with_let", 
      "var_with_init_for_expr_with_let_list", "$accept", };

  static GPPGParser() {
    states[0] = new State(new int[]{59,1563,11,640,86,1638,88,1643,87,1650,74,1656,76,1662,3,-27,50,-27,89,-27,57,-27,27,-27,65,-27,48,-27,51,-27,60,-27,42,-27,35,-27,26,-27,24,-27,28,-27,29,-27,103,-211,104,-211,107,-211},new int[]{-1,1,-230,3,-231,4,-303,1575,-6,1576,-246,1094,-171,1637});
    states[1] = new State(new int[]{2,2});
    states[2] = new State(-1);
    states[3] = new State(-2);
    states[4] = new State(new int[]{3,1559,50,-14,89,-14,57,-14,27,-14,65,-14,48,-14,51,-14,60,-14,11,-14,42,-14,35,-14,26,-14,24,-14,28,-14,29,-14},new int[]{-181,5,-182,1557,-180,1562});
    states[5] = new State(-41,new int[]{-299,6});
    states[6] = new State(new int[]{50,1545,57,-67,27,-67,65,-67,48,-67,51,-67,60,-67,11,-67,42,-67,35,-67,26,-67,24,-67,28,-67,29,-67,89,-67},new int[]{-18,7,-301,14,-37,15,-41,1480,-42,1481});
    states[7] = new State(new int[]{7,9,10,10,5,11,98,12,6,13,2,-26},new int[]{-184,8});
    states[8] = new State(-20);
    states[9] = new State(-21);
    states[10] = new State(-22);
    states[11] = new State(-23);
    states[12] = new State(-24);
    states[13] = new State(-25);
    states[14] = new State(-42);
    states[15] = new State(new int[]{89,17},new int[]{-251,16});
    states[16] = new State(-34);
    states[17] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,741,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,90,-487,10,-487},new int[]{-248,18,-257,739,-256,22,-4,23,-109,24,-128,367,-108,534,-143,740,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871,-139,1026});
    states[18] = new State(new int[]{90,19,10,20});
    states[19] = new State(-524);
    states[20] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,741,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,90,-487,10,-487,96,-487,99,-487,31,-487,102,-487,2,-487},new int[]{-257,21,-256,22,-4,23,-109,24,-128,367,-108,534,-143,740,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871,-139,1026});
    states[21] = new State(-526);
    states[22] = new State(-485);
    states[23] = new State(-488);
    states[24] = new State(new int[]{108,409,109,410,110,411,111,412,112,413,90,-522,10,-522,96,-522,99,-522,31,-522,102,-522,2,-522,98,-522,12,-522,9,-522,97,-522,30,-522,84,-522,83,-522,82,-522,81,-522,80,-522,85,-522},new int[]{-190,25});
    states[25] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,652,8,445,19,264,20,269,75,456,38,550,5,559,18,669,35,678,42,684},new int[]{-86,26,-85,27,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558,-319,653,-97,654,-320,677});
    states[26] = new State(-515);
    states[27] = new State(-590);
    states[28] = new State(-593);
    states[29] = new State(new int[]{16,30,90,-595,10,-595,96,-595,99,-595,31,-595,102,-595,2,-595,98,-595,12,-595,9,-595,97,-595,30,-595,84,-595,83,-595,82,-595,81,-595,80,-595,85,-595,6,-595,75,-595,5,-595,49,-595,56,-595,139,-595,141,-595,79,-595,77,-595,43,-595,40,-595,8,-595,19,-595,20,-595,142,-595,144,-595,143,-595,152,-595,155,-595,154,-595,153,-595,55,-595,89,-595,38,-595,23,-595,95,-595,52,-595,33,-595,53,-595,100,-595,45,-595,34,-595,51,-595,58,-595,73,-595,71,-595,36,-595,69,-595,70,-595,13,-598});
    states[30] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456},new int[]{-95,31,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540});
    states[31] = new State(new int[]{118,308,123,309,121,310,119,311,122,312,120,313,135,314,16,-608,90,-608,10,-608,96,-608,99,-608,31,-608,102,-608,2,-608,98,-608,12,-608,9,-608,97,-608,30,-608,84,-608,83,-608,82,-608,81,-608,80,-608,85,-608,13,-608,6,-608,75,-608,5,-608,49,-608,56,-608,139,-608,141,-608,79,-608,77,-608,43,-608,40,-608,8,-608,19,-608,20,-608,142,-608,144,-608,143,-608,152,-608,155,-608,154,-608,153,-608,55,-608,89,-608,38,-608,23,-608,95,-608,52,-608,33,-608,53,-608,100,-608,45,-608,34,-608,51,-608,58,-608,73,-608,71,-608,36,-608,69,-608,70,-608,114,-608,113,-608,126,-608,127,-608,124,-608,136,-608,134,-608,116,-608,115,-608,129,-608,130,-608,131,-608,132,-608,128,-608},new int[]{-192,32});
    states[32] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-102,33,-238,1479,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,563,-263,540});
    states[33] = new State(new int[]{6,34,118,-631,123,-631,121,-631,119,-631,122,-631,120,-631,135,-631,16,-631,90,-631,10,-631,96,-631,99,-631,31,-631,102,-631,2,-631,98,-631,12,-631,9,-631,97,-631,30,-631,84,-631,83,-631,82,-631,81,-631,80,-631,85,-631,13,-631,75,-631,5,-631,49,-631,56,-631,139,-631,141,-631,79,-631,77,-631,43,-631,40,-631,8,-631,19,-631,20,-631,142,-631,144,-631,143,-631,152,-631,155,-631,154,-631,153,-631,55,-631,89,-631,38,-631,23,-631,95,-631,52,-631,33,-631,53,-631,100,-631,45,-631,34,-631,51,-631,58,-631,73,-631,71,-631,36,-631,69,-631,70,-631,114,-631,113,-631,126,-631,127,-631,124,-631,136,-631,134,-631,116,-631,115,-631,129,-631,130,-631,131,-631,132,-631,128,-631});
    states[34] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456},new int[]{-81,35,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,563,-263,540});
    states[35] = new State(new int[]{114,321,113,322,126,323,127,324,124,325,6,-709,5,-709,118,-709,123,-709,121,-709,119,-709,122,-709,120,-709,135,-709,16,-709,90,-709,10,-709,96,-709,99,-709,31,-709,102,-709,2,-709,98,-709,12,-709,9,-709,97,-709,30,-709,84,-709,83,-709,82,-709,81,-709,80,-709,85,-709,13,-709,75,-709,49,-709,56,-709,139,-709,141,-709,79,-709,77,-709,43,-709,40,-709,8,-709,19,-709,20,-709,142,-709,144,-709,143,-709,152,-709,155,-709,154,-709,153,-709,55,-709,89,-709,38,-709,23,-709,95,-709,52,-709,33,-709,53,-709,100,-709,45,-709,34,-709,51,-709,58,-709,73,-709,71,-709,36,-709,69,-709,70,-709,136,-709,134,-709,116,-709,115,-709,129,-709,130,-709,131,-709,132,-709,128,-709},new int[]{-193,36});
    states[36] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-80,37,-238,1478,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,563,-263,540});
    states[37] = new State(new int[]{136,327,134,1444,116,1447,115,1448,129,1449,130,1450,131,1451,132,1452,128,1453,114,-711,113,-711,126,-711,127,-711,124,-711,6,-711,5,-711,118,-711,123,-711,121,-711,119,-711,122,-711,120,-711,135,-711,16,-711,90,-711,10,-711,96,-711,99,-711,31,-711,102,-711,2,-711,98,-711,12,-711,9,-711,97,-711,30,-711,84,-711,83,-711,82,-711,81,-711,80,-711,85,-711,13,-711,75,-711,49,-711,56,-711,139,-711,141,-711,79,-711,77,-711,43,-711,40,-711,8,-711,19,-711,20,-711,142,-711,144,-711,143,-711,152,-711,155,-711,154,-711,153,-711,55,-711,89,-711,38,-711,23,-711,95,-711,52,-711,33,-711,53,-711,100,-711,45,-711,34,-711,51,-711,58,-711,73,-711,71,-711,36,-711,69,-711,70,-711},new int[]{-194,38});
    states[38] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,53,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-93,39,-264,40,-238,41,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-94,465});
    states[39] = new State(-732);
    states[40] = new State(-733);
    states[41] = new State(-734);
    states[42] = new State(-747);
    states[43] = new State(new int[]{7,44,136,-748,134,-748,116,-748,115,-748,129,-748,130,-748,131,-748,132,-748,128,-748,114,-748,113,-748,126,-748,127,-748,124,-748,6,-748,5,-748,118,-748,123,-748,121,-748,119,-748,122,-748,120,-748,135,-748,16,-748,90,-748,10,-748,96,-748,99,-748,31,-748,102,-748,2,-748,98,-748,12,-748,9,-748,97,-748,30,-748,84,-748,83,-748,82,-748,81,-748,80,-748,85,-748,13,-748,75,-748,49,-748,56,-748,139,-748,141,-748,79,-748,77,-748,43,-748,40,-748,8,-748,19,-748,20,-748,142,-748,144,-748,143,-748,152,-748,155,-748,154,-748,153,-748,55,-748,89,-748,38,-748,23,-748,95,-748,52,-748,33,-748,53,-748,100,-748,45,-748,34,-748,51,-748,58,-748,73,-748,71,-748,36,-748,69,-748,70,-748,11,-772,17,-772,117,-745});
    states[44] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,83,56,82,57,81,58,80,59,67,60,62,61,126,62,20,63,19,64,61,65,21,66,127,67,128,68,129,69,130,70,131,71,132,72,133,73,134,74,135,75,136,76,22,77,72,78,89,79,23,80,24,81,27,82,28,83,29,84,70,85,97,86,30,87,90,88,31,89,32,90,25,91,102,92,99,93,33,94,34,95,35,96,38,97,39,98,40,99,101,100,41,101,42,102,44,103,45,104,46,105,95,106,47,107,100,108,48,109,26,110,49,111,69,112,96,113,50,114,51,115,52,116,53,117,54,118,55,119,56,120,57,121,59,122,103,123,104,124,107,125,105,126,106,127,60,128,73,129,36,130,37,131,68,132,145,133,58,134,137,135,138,136,78,137,150,138,149,139,71,140,151,141,147,142,148,143,146,144,43,146},new int[]{-134,45,-143,46,-147,48,-148,51,-289,54,-146,55,-290,145});
    states[45] = new State(-783);
    states[46] = new State(-816);
    states[47] = new State(-813);
    states[48] = new State(-814);
    states[49] = new State(-832);
    states[50] = new State(-833);
    states[51] = new State(-815);
    states[52] = new State(-834);
    states[53] = new State(-835);
    states[54] = new State(-817);
    states[55] = new State(-840);
    states[56] = new State(-836);
    states[57] = new State(-837);
    states[58] = new State(-838);
    states[59] = new State(-839);
    states[60] = new State(-841);
    states[61] = new State(-842);
    states[62] = new State(-843);
    states[63] = new State(-844);
    states[64] = new State(-845);
    states[65] = new State(-846);
    states[66] = new State(-847);
    states[67] = new State(-848);
    states[68] = new State(-849);
    states[69] = new State(-850);
    states[70] = new State(-851);
    states[71] = new State(-852);
    states[72] = new State(-853);
    states[73] = new State(-854);
    states[74] = new State(-855);
    states[75] = new State(-856);
    states[76] = new State(-857);
    states[77] = new State(-858);
    states[78] = new State(-859);
    states[79] = new State(-860);
    states[80] = new State(-861);
    states[81] = new State(-862);
    states[82] = new State(-863);
    states[83] = new State(-864);
    states[84] = new State(-865);
    states[85] = new State(-866);
    states[86] = new State(-867);
    states[87] = new State(-868);
    states[88] = new State(-869);
    states[89] = new State(-870);
    states[90] = new State(-871);
    states[91] = new State(-872);
    states[92] = new State(-873);
    states[93] = new State(-874);
    states[94] = new State(-875);
    states[95] = new State(-876);
    states[96] = new State(-877);
    states[97] = new State(-878);
    states[98] = new State(-879);
    states[99] = new State(-880);
    states[100] = new State(-881);
    states[101] = new State(-882);
    states[102] = new State(-883);
    states[103] = new State(-884);
    states[104] = new State(-885);
    states[105] = new State(-886);
    states[106] = new State(-887);
    states[107] = new State(-888);
    states[108] = new State(-889);
    states[109] = new State(-890);
    states[110] = new State(-891);
    states[111] = new State(-892);
    states[112] = new State(-893);
    states[113] = new State(-894);
    states[114] = new State(-895);
    states[115] = new State(-896);
    states[116] = new State(-897);
    states[117] = new State(-898);
    states[118] = new State(-899);
    states[119] = new State(-900);
    states[120] = new State(-901);
    states[121] = new State(-902);
    states[122] = new State(-903);
    states[123] = new State(-904);
    states[124] = new State(-905);
    states[125] = new State(-906);
    states[126] = new State(-907);
    states[127] = new State(-908);
    states[128] = new State(-909);
    states[129] = new State(-910);
    states[130] = new State(-911);
    states[131] = new State(-912);
    states[132] = new State(-913);
    states[133] = new State(-914);
    states[134] = new State(-915);
    states[135] = new State(-916);
    states[136] = new State(-917);
    states[137] = new State(-918);
    states[138] = new State(-919);
    states[139] = new State(-920);
    states[140] = new State(-921);
    states[141] = new State(-922);
    states[142] = new State(-923);
    states[143] = new State(-924);
    states[144] = new State(-925);
    states[145] = new State(-818);
    states[146] = new State(-926);
    states[147] = new State(-756);
    states[148] = new State(new int[]{142,150,144,151,7,-802,11,-802,17,-802,136,-802,134,-802,116,-802,115,-802,129,-802,130,-802,131,-802,132,-802,128,-802,114,-802,113,-802,126,-802,127,-802,124,-802,6,-802,5,-802,118,-802,123,-802,121,-802,119,-802,122,-802,120,-802,135,-802,16,-802,90,-802,10,-802,96,-802,99,-802,31,-802,102,-802,2,-802,98,-802,12,-802,9,-802,97,-802,30,-802,84,-802,83,-802,82,-802,81,-802,80,-802,85,-802,13,-802,117,-802,75,-802,49,-802,56,-802,139,-802,141,-802,79,-802,77,-802,43,-802,40,-802,8,-802,19,-802,20,-802,143,-802,152,-802,155,-802,154,-802,153,-802,55,-802,89,-802,38,-802,23,-802,95,-802,52,-802,33,-802,53,-802,100,-802,45,-802,34,-802,51,-802,58,-802,73,-802,71,-802,36,-802,69,-802,70,-802,125,-802,108,-802,4,-802,140,-802},new int[]{-162,149});
    states[149] = new State(-805);
    states[150] = new State(-800);
    states[151] = new State(-801);
    states[152] = new State(-804);
    states[153] = new State(-803);
    states[154] = new State(-757);
    states[155] = new State(-189);
    states[156] = new State(-190);
    states[157] = new State(-191);
    states[158] = new State(-192);
    states[159] = new State(-749);
    states[160] = new State(new int[]{8,161});
    states[161] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-280,162,-176,164,-143,201,-147,48,-148,51});
    states[162] = new State(new int[]{9,163});
    states[163] = new State(-743);
    states[164] = new State(new int[]{7,165,4,168,121,170,9,-616,134,-616,136,-616,116,-616,115,-616,129,-616,130,-616,131,-616,132,-616,128,-616,114,-616,113,-616,126,-616,127,-616,118,-616,123,-616,119,-616,122,-616,120,-616,135,-616,13,-616,16,-616,6,-616,98,-616,12,-616,5,-616,90,-616,10,-616,96,-616,99,-616,31,-616,102,-616,2,-616,97,-616,30,-616,84,-616,83,-616,82,-616,81,-616,80,-616,85,-616,11,-616,8,-616,124,-616,75,-616,49,-616,56,-616,139,-616,141,-616,79,-616,77,-616,43,-616,40,-616,19,-616,20,-616,142,-616,144,-616,143,-616,152,-616,155,-616,154,-616,153,-616,55,-616,89,-616,38,-616,23,-616,95,-616,52,-616,33,-616,53,-616,100,-616,45,-616,34,-616,51,-616,58,-616,73,-616,71,-616,36,-616,69,-616,70,-616},new int[]{-295,167});
    states[165] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,83,56,82,57,81,58,80,59,67,60,62,61,126,62,20,63,19,64,61,65,21,66,127,67,128,68,129,69,130,70,131,71,132,72,133,73,134,74,135,75,136,76,22,77,72,78,89,79,23,80,24,81,27,82,28,83,29,84,70,85,97,86,30,87,90,88,31,89,32,90,25,91,102,92,99,93,33,94,34,95,35,96,38,97,39,98,40,99,101,100,41,101,42,102,44,103,45,104,46,105,95,106,47,107,100,108,48,109,26,110,49,111,69,112,96,113,50,114,51,115,52,116,53,117,54,118,55,119,56,120,57,121,59,122,103,123,104,124,107,125,105,126,106,127,60,128,73,129,36,130,37,131,68,132,145,133,58,134,137,135,138,136,78,137,150,138,149,139,71,140,151,141,147,142,148,143,146,144,43,146},new int[]{-134,166,-143,46,-147,48,-148,51,-289,54,-146,55,-290,145});
    states[166] = new State(-260);
    states[167] = new State(-617);
    states[168] = new State(new int[]{121,170},new int[]{-295,169});
    states[169] = new State(-618);
    states[170] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-293,171,-275,283,-268,175,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-277,1398,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,1399,-220,599,-219,600,-297,1400});
    states[171] = new State(new int[]{119,172,98,173});
    states[172] = new State(-234);
    states[173] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-275,174,-268,175,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-277,1398,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,1399,-220,599,-219,600,-297,1400});
    states[174] = new State(-238);
    states[175] = new State(new int[]{13,176,119,-242,98,-242,118,-242,9,-242,8,-242,136,-242,134,-242,116,-242,115,-242,129,-242,130,-242,131,-242,132,-242,128,-242,114,-242,113,-242,126,-242,127,-242,124,-242,6,-242,5,-242,123,-242,121,-242,122,-242,120,-242,135,-242,16,-242,90,-242,10,-242,96,-242,99,-242,31,-242,102,-242,2,-242,12,-242,97,-242,30,-242,84,-242,83,-242,82,-242,81,-242,80,-242,85,-242,75,-242,49,-242,56,-242,139,-242,141,-242,79,-242,77,-242,43,-242,40,-242,19,-242,20,-242,142,-242,144,-242,143,-242,152,-242,155,-242,154,-242,153,-242,55,-242,89,-242,38,-242,23,-242,95,-242,52,-242,33,-242,53,-242,100,-242,45,-242,34,-242,51,-242,58,-242,73,-242,71,-242,36,-242,69,-242,70,-242,125,-242,108,-242});
    states[176] = new State(-243);
    states[177] = new State(new int[]{6,1476,114,228,113,229,126,230,127,231,13,-247,119,-247,98,-247,118,-247,9,-247,8,-247,136,-247,134,-247,116,-247,115,-247,129,-247,130,-247,131,-247,132,-247,128,-247,124,-247,5,-247,123,-247,121,-247,122,-247,120,-247,135,-247,16,-247,90,-247,10,-247,96,-247,99,-247,31,-247,102,-247,2,-247,12,-247,97,-247,30,-247,84,-247,83,-247,82,-247,81,-247,80,-247,85,-247,75,-247,49,-247,56,-247,139,-247,141,-247,79,-247,77,-247,43,-247,40,-247,19,-247,20,-247,142,-247,144,-247,143,-247,152,-247,155,-247,154,-247,153,-247,55,-247,89,-247,38,-247,23,-247,95,-247,52,-247,33,-247,53,-247,100,-247,45,-247,34,-247,51,-247,58,-247,73,-247,71,-247,36,-247,69,-247,70,-247,125,-247,108,-247},new int[]{-189,178});
    states[178] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153},new int[]{-103,179,-104,285,-176,485,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152});
    states[179] = new State(new int[]{116,235,115,236,129,237,130,238,131,239,132,240,128,241,6,-251,114,-251,113,-251,126,-251,127,-251,13,-251,119,-251,98,-251,118,-251,9,-251,8,-251,136,-251,134,-251,124,-251,5,-251,123,-251,121,-251,122,-251,120,-251,135,-251,16,-251,90,-251,10,-251,96,-251,99,-251,31,-251,102,-251,2,-251,12,-251,97,-251,30,-251,84,-251,83,-251,82,-251,81,-251,80,-251,85,-251,75,-251,49,-251,56,-251,139,-251,141,-251,79,-251,77,-251,43,-251,40,-251,19,-251,20,-251,142,-251,144,-251,143,-251,152,-251,155,-251,154,-251,153,-251,55,-251,89,-251,38,-251,23,-251,95,-251,52,-251,33,-251,53,-251,100,-251,45,-251,34,-251,51,-251,58,-251,73,-251,71,-251,36,-251,69,-251,70,-251,125,-251,108,-251},new int[]{-191,180});
    states[180] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153},new int[]{-104,181,-176,485,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152});
    states[181] = new State(new int[]{8,182,116,-253,115,-253,129,-253,130,-253,131,-253,132,-253,128,-253,6,-253,114,-253,113,-253,126,-253,127,-253,13,-253,119,-253,98,-253,118,-253,9,-253,136,-253,134,-253,124,-253,5,-253,123,-253,121,-253,122,-253,120,-253,135,-253,16,-253,90,-253,10,-253,96,-253,99,-253,31,-253,102,-253,2,-253,12,-253,97,-253,30,-253,84,-253,83,-253,82,-253,81,-253,80,-253,85,-253,75,-253,49,-253,56,-253,139,-253,141,-253,79,-253,77,-253,43,-253,40,-253,19,-253,20,-253,142,-253,144,-253,143,-253,152,-253,155,-253,154,-253,153,-253,55,-253,89,-253,38,-253,23,-253,95,-253,52,-253,33,-253,53,-253,100,-253,45,-253,34,-253,51,-253,58,-253,73,-253,71,-253,36,-253,69,-253,70,-253,125,-253,108,-253});
    states[182] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160,9,-184},new int[]{-73,183,-71,185,-91,1475,-87,188,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840});
    states[183] = new State(new int[]{9,184});
    states[184] = new State(-258);
    states[185] = new State(new int[]{98,186,9,-183,12,-183});
    states[186] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160},new int[]{-91,187,-87,188,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840});
    states[187] = new State(-186);
    states[188] = new State(new int[]{13,189,16,193,6,1469,98,-187,9,-187,12,-187,5,-187});
    states[189] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160},new int[]{-87,190,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840});
    states[190] = new State(new int[]{5,191,13,189,16,193});
    states[191] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160},new int[]{-87,192,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840});
    states[192] = new State(new int[]{13,189,16,193,6,-123,98,-123,9,-123,12,-123,5,-123,90,-123,10,-123,96,-123,99,-123,31,-123,102,-123,2,-123,97,-123,30,-123,84,-123,83,-123,82,-123,81,-123,80,-123,85,-123});
    states[193] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160},new int[]{-88,194,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834});
    states[194] = new State(new int[]{118,220,123,221,121,222,119,223,122,224,120,225,135,226,13,-122,16,-122,6,-122,98,-122,9,-122,12,-122,5,-122,90,-122,10,-122,96,-122,99,-122,31,-122,102,-122,2,-122,97,-122,30,-122,84,-122,83,-122,82,-122,81,-122,80,-122,85,-122},new int[]{-188,195});
    states[195] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160},new int[]{-79,196,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834});
    states[196] = new State(new int[]{114,228,113,229,126,230,127,231,118,-119,123,-119,121,-119,119,-119,122,-119,120,-119,135,-119,13,-119,16,-119,6,-119,98,-119,9,-119,12,-119,5,-119,90,-119,10,-119,96,-119,99,-119,31,-119,102,-119,2,-119,97,-119,30,-119,84,-119,83,-119,82,-119,81,-119,80,-119,85,-119},new int[]{-189,197});
    states[197] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160},new int[]{-13,198,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834});
    states[198] = new State(new int[]{134,233,136,234,116,235,115,236,129,237,130,238,131,239,132,240,128,241,114,-132,113,-132,126,-132,127,-132,118,-132,123,-132,121,-132,119,-132,122,-132,120,-132,135,-132,13,-132,16,-132,6,-132,98,-132,9,-132,12,-132,5,-132,90,-132,10,-132,96,-132,99,-132,31,-132,102,-132,2,-132,97,-132,30,-132,84,-132,83,-132,82,-132,81,-132,80,-132,85,-132},new int[]{-197,199,-191,202});
    states[199] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-280,200,-176,164,-143,201,-147,48,-148,51});
    states[200] = new State(-137);
    states[201] = new State(-259);
    states[202] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160},new int[]{-10,203,-265,204,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-11,834});
    states[203] = new State(-144);
    states[204] = new State(-145);
    states[205] = new State(new int[]{4,207,11,209,7,813,140,815,8,816,134,-155,136,-155,116,-155,115,-155,129,-155,130,-155,131,-155,132,-155,128,-155,114,-155,113,-155,126,-155,127,-155,118,-155,123,-155,121,-155,119,-155,122,-155,120,-155,135,-155,13,-155,16,-155,6,-155,98,-155,9,-155,12,-155,5,-155,90,-155,10,-155,96,-155,99,-155,31,-155,102,-155,2,-155,97,-155,30,-155,84,-155,83,-155,82,-155,81,-155,80,-155,85,-155,117,-153},new int[]{-12,206});
    states[206] = new State(-174);
    states[207] = new State(new int[]{121,170},new int[]{-295,208});
    states[208] = new State(-175);
    states[209] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160,5,1471,12,-184},new int[]{-117,210,-73,212,-87,214,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840,-71,185,-91,1475});
    states[210] = new State(new int[]{12,211});
    states[211] = new State(-176);
    states[212] = new State(new int[]{12,213});
    states[213] = new State(-180);
    states[214] = new State(new int[]{5,215,13,189,16,193,6,1469,98,-187,12,-187});
    states[215] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160,5,-692,12,-692},new int[]{-118,216,-87,1468,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840});
    states[216] = new State(new int[]{5,217,12,-697});
    states[217] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160},new int[]{-87,218,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840});
    states[218] = new State(new int[]{13,189,16,193,12,-699});
    states[219] = new State(new int[]{118,220,123,221,121,222,119,223,122,224,120,225,135,226,13,-120,16,-120,6,-120,98,-120,9,-120,12,-120,5,-120,90,-120,10,-120,96,-120,99,-120,31,-120,102,-120,2,-120,97,-120,30,-120,84,-120,83,-120,82,-120,81,-120,80,-120,85,-120},new int[]{-188,195});
    states[220] = new State(-124);
    states[221] = new State(-125);
    states[222] = new State(-126);
    states[223] = new State(-127);
    states[224] = new State(-128);
    states[225] = new State(-129);
    states[226] = new State(-130);
    states[227] = new State(new int[]{114,228,113,229,126,230,127,231,118,-118,123,-118,121,-118,119,-118,122,-118,120,-118,135,-118,13,-118,16,-118,6,-118,98,-118,9,-118,12,-118,5,-118,90,-118,10,-118,96,-118,99,-118,31,-118,102,-118,2,-118,97,-118,30,-118,84,-118,83,-118,82,-118,81,-118,80,-118,85,-118},new int[]{-189,197});
    states[228] = new State(-133);
    states[229] = new State(-134);
    states[230] = new State(-135);
    states[231] = new State(-136);
    states[232] = new State(new int[]{134,233,136,234,116,235,115,236,129,237,130,238,131,239,132,240,128,241,114,-131,113,-131,126,-131,127,-131,118,-131,123,-131,121,-131,119,-131,122,-131,120,-131,135,-131,13,-131,16,-131,6,-131,98,-131,9,-131,12,-131,5,-131,90,-131,10,-131,96,-131,99,-131,31,-131,102,-131,2,-131,97,-131,30,-131,84,-131,83,-131,82,-131,81,-131,80,-131,85,-131},new int[]{-197,199,-191,202});
    states[233] = new State(-718);
    states[234] = new State(-719);
    states[235] = new State(-146);
    states[236] = new State(-147);
    states[237] = new State(-148);
    states[238] = new State(-149);
    states[239] = new State(-150);
    states[240] = new State(-151);
    states[241] = new State(-152);
    states[242] = new State(-141);
    states[243] = new State(-168);
    states[244] = new State(new int[]{24,1457,141,47,84,49,85,50,79,52,77,53,8,-835,7,-835,140,-835,4,-835,15,-835,17,-835,108,-835,109,-835,110,-835,111,-835,112,-835,90,-835,10,-835,11,-835,5,-835,96,-835,99,-835,31,-835,102,-835,2,-835,125,-835,136,-835,134,-835,116,-835,115,-835,129,-835,130,-835,131,-835,132,-835,128,-835,114,-835,113,-835,126,-835,127,-835,124,-835,6,-835,118,-835,123,-835,121,-835,119,-835,122,-835,120,-835,135,-835,16,-835,98,-835,12,-835,9,-835,97,-835,30,-835,83,-835,82,-835,81,-835,80,-835,13,-835,117,-835,75,-835,49,-835,56,-835,139,-835,43,-835,40,-835,19,-835,20,-835,142,-835,144,-835,143,-835,152,-835,155,-835,154,-835,153,-835,55,-835,89,-835,38,-835,23,-835,95,-835,52,-835,33,-835,53,-835,100,-835,45,-835,34,-835,51,-835,58,-835,73,-835,71,-835,36,-835,69,-835,70,-835},new int[]{-280,245,-176,164,-143,201,-147,48,-148,51});
    states[245] = new State(new int[]{11,247,8,649,90,-628,10,-628,96,-628,99,-628,31,-628,102,-628,2,-628,136,-628,134,-628,116,-628,115,-628,129,-628,130,-628,131,-628,132,-628,128,-628,114,-628,113,-628,126,-628,127,-628,124,-628,6,-628,5,-628,118,-628,123,-628,121,-628,119,-628,122,-628,120,-628,135,-628,16,-628,98,-628,12,-628,9,-628,97,-628,30,-628,84,-628,83,-628,82,-628,81,-628,80,-628,85,-628,13,-628,75,-628,49,-628,56,-628,139,-628,141,-628,79,-628,77,-628,43,-628,40,-628,19,-628,20,-628,142,-628,144,-628,143,-628,152,-628,155,-628,154,-628,153,-628,55,-628,89,-628,38,-628,23,-628,95,-628,52,-628,33,-628,53,-628,100,-628,45,-628,34,-628,51,-628,58,-628,73,-628,71,-628,36,-628,69,-628,70,-628},new int[]{-69,246});
    states[246] = new State(-621);
    states[247] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,652,8,445,19,264,20,269,75,456,38,550,5,559,18,669,35,678,42,684,12,-793},new int[]{-67,248,-70,372,-86,438,-85,27,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558,-319,653,-97,654,-320,677});
    states[248] = new State(new int[]{12,249});
    states[249] = new State(new int[]{8,251,90,-620,10,-620,96,-620,99,-620,31,-620,102,-620,2,-620,136,-620,134,-620,116,-620,115,-620,129,-620,130,-620,131,-620,132,-620,128,-620,114,-620,113,-620,126,-620,127,-620,124,-620,6,-620,5,-620,118,-620,123,-620,121,-620,119,-620,122,-620,120,-620,135,-620,16,-620,98,-620,12,-620,9,-620,97,-620,30,-620,84,-620,83,-620,82,-620,81,-620,80,-620,85,-620,13,-620,75,-620,49,-620,56,-620,139,-620,141,-620,79,-620,77,-620,43,-620,40,-620,19,-620,20,-620,142,-620,144,-620,143,-620,152,-620,155,-620,154,-620,153,-620,55,-620,89,-620,38,-620,23,-620,95,-620,52,-620,33,-620,53,-620,100,-620,45,-620,34,-620,51,-620,58,-620,73,-620,71,-620,36,-620,69,-620,70,-620},new int[]{-5,250});
    states[250] = new State(-622);
    states[251] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,986,133,826,114,362,113,363,61,160,9,-197},new int[]{-66,252,-65,254,-83,989,-82,257,-87,258,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840,-92,990,-239,991});
    states[252] = new State(new int[]{9,253});
    states[253] = new State(-619);
    states[254] = new State(new int[]{98,255,9,-198});
    states[255] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,986,133,826,114,362,113,363,61,160},new int[]{-83,256,-82,257,-87,258,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840,-92,990,-239,991});
    states[256] = new State(-200);
    states[257] = new State(-415);
    states[258] = new State(new int[]{13,189,16,193,98,-193,9,-193,90,-193,10,-193,96,-193,99,-193,31,-193,102,-193,2,-193,12,-193,97,-193,30,-193,84,-193,83,-193,82,-193,81,-193,80,-193,85,-193});
    states[259] = new State(-169);
    states[260] = new State(-170);
    states[261] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-143,262,-147,48,-148,51});
    states[262] = new State(-171);
    states[263] = new State(-172);
    states[264] = new State(new int[]{8,265});
    states[265] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-280,266,-176,164,-143,201,-147,48,-148,51});
    states[266] = new State(new int[]{9,267});
    states[267] = new State(-609);
    states[268] = new State(-173);
    states[269] = new State(new int[]{8,270});
    states[270] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-280,271,-279,273,-176,275,-143,201,-147,48,-148,51});
    states[271] = new State(new int[]{9,272});
    states[272] = new State(-610);
    states[273] = new State(new int[]{9,274});
    states[274] = new State(-611);
    states[275] = new State(new int[]{7,165,4,276,121,278,123,1455,9,-616},new int[]{-295,167,-296,1456});
    states[276] = new State(new int[]{121,278,123,1455},new int[]{-295,169,-296,277});
    states[277] = new State(-615);
    states[278] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616,119,-241,98,-241},new int[]{-293,171,-294,279,-275,283,-268,175,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-277,1398,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,1399,-220,599,-219,600,-297,1400,-276,1454});
    states[279] = new State(new int[]{119,280,98,281});
    states[280] = new State(-236);
    states[281] = new State(-241,new int[]{-276,282});
    states[282] = new State(-240);
    states[283] = new State(-237);
    states[284] = new State(new int[]{116,235,115,236,129,237,130,238,131,239,132,240,128,241,6,-250,114,-250,113,-250,126,-250,127,-250,13,-250,119,-250,98,-250,118,-250,9,-250,8,-250,136,-250,134,-250,124,-250,5,-250,123,-250,121,-250,122,-250,120,-250,135,-250,16,-250,90,-250,10,-250,96,-250,99,-250,31,-250,102,-250,2,-250,12,-250,97,-250,30,-250,84,-250,83,-250,82,-250,81,-250,80,-250,85,-250,75,-250,49,-250,56,-250,139,-250,141,-250,79,-250,77,-250,43,-250,40,-250,19,-250,20,-250,142,-250,144,-250,143,-250,152,-250,155,-250,154,-250,153,-250,55,-250,89,-250,38,-250,23,-250,95,-250,52,-250,33,-250,53,-250,100,-250,45,-250,34,-250,51,-250,58,-250,73,-250,71,-250,36,-250,69,-250,70,-250,125,-250,108,-250},new int[]{-191,180});
    states[285] = new State(new int[]{8,182,116,-252,115,-252,129,-252,130,-252,131,-252,132,-252,128,-252,6,-252,114,-252,113,-252,126,-252,127,-252,13,-252,119,-252,98,-252,118,-252,9,-252,136,-252,134,-252,124,-252,5,-252,123,-252,121,-252,122,-252,120,-252,135,-252,16,-252,90,-252,10,-252,96,-252,99,-252,31,-252,102,-252,2,-252,12,-252,97,-252,30,-252,84,-252,83,-252,82,-252,81,-252,80,-252,85,-252,75,-252,49,-252,56,-252,139,-252,141,-252,79,-252,77,-252,43,-252,40,-252,19,-252,20,-252,142,-252,144,-252,143,-252,152,-252,155,-252,154,-252,153,-252,55,-252,89,-252,38,-252,23,-252,95,-252,52,-252,33,-252,53,-252,100,-252,45,-252,34,-252,51,-252,58,-252,73,-252,71,-252,36,-252,69,-252,70,-252,125,-252,108,-252});
    states[286] = new State(new int[]{7,165,125,287,121,170,8,-254,116,-254,115,-254,129,-254,130,-254,131,-254,132,-254,128,-254,6,-254,114,-254,113,-254,126,-254,127,-254,13,-254,119,-254,98,-254,118,-254,9,-254,136,-254,134,-254,124,-254,5,-254,123,-254,122,-254,120,-254,135,-254,16,-254,90,-254,10,-254,96,-254,99,-254,31,-254,102,-254,2,-254,12,-254,97,-254,30,-254,84,-254,83,-254,82,-254,81,-254,80,-254,85,-254,75,-254,49,-254,56,-254,139,-254,141,-254,79,-254,77,-254,43,-254,40,-254,19,-254,20,-254,142,-254,144,-254,143,-254,152,-254,155,-254,154,-254,153,-254,55,-254,89,-254,38,-254,23,-254,95,-254,52,-254,33,-254,53,-254,100,-254,45,-254,34,-254,51,-254,58,-254,73,-254,71,-254,36,-254,69,-254,70,-254,108,-254},new int[]{-295,648});
    states[287] = new State(new int[]{8,289,141,47,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-275,288,-268,175,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-277,1398,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,1399,-220,599,-219,600,-297,1400});
    states[288] = new State(-289);
    states[289] = new State(new int[]{9,290,141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-78,295,-76,301,-272,304,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[290] = new State(new int[]{125,291,119,-293,98,-293,118,-293,9,-293,8,-293,136,-293,134,-293,116,-293,115,-293,129,-293,130,-293,131,-293,132,-293,128,-293,114,-293,113,-293,126,-293,127,-293,124,-293,6,-293,5,-293,123,-293,121,-293,122,-293,120,-293,135,-293,16,-293,90,-293,10,-293,96,-293,99,-293,31,-293,102,-293,2,-293,12,-293,97,-293,30,-293,84,-293,83,-293,82,-293,81,-293,80,-293,85,-293,13,-293,75,-293,49,-293,56,-293,139,-293,141,-293,79,-293,77,-293,43,-293,40,-293,19,-293,20,-293,142,-293,144,-293,143,-293,152,-293,155,-293,154,-293,153,-293,55,-293,89,-293,38,-293,23,-293,95,-293,52,-293,33,-293,53,-293,100,-293,45,-293,34,-293,51,-293,58,-293,73,-293,71,-293,36,-293,69,-293,70,-293,108,-293});
    states[291] = new State(new int[]{8,293,141,47,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-275,292,-268,175,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-277,1398,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,1399,-220,599,-219,600,-297,1400});
    states[292] = new State(-291);
    states[293] = new State(new int[]{9,294,141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-78,295,-76,301,-272,304,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[294] = new State(new int[]{125,291,119,-295,98,-295,118,-295,9,-295,8,-295,136,-295,134,-295,116,-295,115,-295,129,-295,130,-295,131,-295,132,-295,128,-295,114,-295,113,-295,126,-295,127,-295,124,-295,6,-295,5,-295,123,-295,121,-295,122,-295,120,-295,135,-295,16,-295,90,-295,10,-295,96,-295,99,-295,31,-295,102,-295,2,-295,12,-295,97,-295,30,-295,84,-295,83,-295,82,-295,81,-295,80,-295,85,-295,13,-295,75,-295,49,-295,56,-295,139,-295,141,-295,79,-295,77,-295,43,-295,40,-295,19,-295,20,-295,142,-295,144,-295,143,-295,152,-295,155,-295,154,-295,153,-295,55,-295,89,-295,38,-295,23,-295,95,-295,52,-295,33,-295,53,-295,100,-295,45,-295,34,-295,51,-295,58,-295,73,-295,71,-295,36,-295,69,-295,70,-295,108,-295});
    states[295] = new State(new int[]{9,296,98,663});
    states[296] = new State(new int[]{125,297,13,-249,119,-249,98,-249,118,-249,9,-249,8,-249,136,-249,134,-249,116,-249,115,-249,129,-249,130,-249,131,-249,132,-249,128,-249,114,-249,113,-249,126,-249,127,-249,124,-249,6,-249,5,-249,123,-249,121,-249,122,-249,120,-249,135,-249,16,-249,90,-249,10,-249,96,-249,99,-249,31,-249,102,-249,2,-249,12,-249,97,-249,30,-249,84,-249,83,-249,82,-249,81,-249,80,-249,85,-249,75,-249,49,-249,56,-249,139,-249,141,-249,79,-249,77,-249,43,-249,40,-249,19,-249,20,-249,142,-249,144,-249,143,-249,152,-249,155,-249,154,-249,153,-249,55,-249,89,-249,38,-249,23,-249,95,-249,52,-249,33,-249,53,-249,100,-249,45,-249,34,-249,51,-249,58,-249,73,-249,71,-249,36,-249,69,-249,70,-249,108,-249});
    states[297] = new State(new int[]{8,299,141,47,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-275,298,-268,175,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-277,1398,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,1399,-220,599,-219,600,-297,1400});
    states[298] = new State(-292);
    states[299] = new State(new int[]{9,300,141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-78,295,-76,301,-272,304,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[300] = new State(new int[]{125,291,119,-296,98,-296,118,-296,9,-296,8,-296,136,-296,134,-296,116,-296,115,-296,129,-296,130,-296,131,-296,132,-296,128,-296,114,-296,113,-296,126,-296,127,-296,124,-296,6,-296,5,-296,123,-296,121,-296,122,-296,120,-296,135,-296,16,-296,90,-296,10,-296,96,-296,99,-296,31,-296,102,-296,2,-296,12,-296,97,-296,30,-296,84,-296,83,-296,82,-296,81,-296,80,-296,85,-296,13,-296,75,-296,49,-296,56,-296,139,-296,141,-296,79,-296,77,-296,43,-296,40,-296,19,-296,20,-296,142,-296,144,-296,143,-296,152,-296,155,-296,154,-296,153,-296,55,-296,89,-296,38,-296,23,-296,95,-296,52,-296,33,-296,53,-296,100,-296,45,-296,34,-296,51,-296,58,-296,73,-296,71,-296,36,-296,69,-296,70,-296,108,-296});
    states[301] = new State(new int[]{98,302});
    states[302] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-76,303,-272,304,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[303] = new State(-261);
    states[304] = new State(new int[]{118,305,98,-263,9,-263});
    states[305] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559},new int[]{-85,306,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558});
    states[306] = new State(-264);
    states[307] = new State(new int[]{118,308,123,309,121,310,119,311,122,312,120,313,135,314,16,-607,90,-607,10,-607,96,-607,99,-607,31,-607,102,-607,2,-607,98,-607,12,-607,9,-607,97,-607,30,-607,84,-607,83,-607,82,-607,81,-607,80,-607,85,-607,13,-607,6,-607,75,-607,5,-607,49,-607,56,-607,139,-607,141,-607,79,-607,77,-607,43,-607,40,-607,8,-607,19,-607,20,-607,142,-607,144,-607,143,-607,152,-607,155,-607,154,-607,153,-607,55,-607,89,-607,38,-607,23,-607,95,-607,52,-607,33,-607,53,-607,100,-607,45,-607,34,-607,51,-607,58,-607,73,-607,71,-607,36,-607,69,-607,70,-607,114,-607,113,-607,126,-607,127,-607,124,-607,136,-607,134,-607,116,-607,115,-607,129,-607,130,-607,131,-607,132,-607,128,-607},new int[]{-192,32});
    states[308] = new State(-701);
    states[309] = new State(-702);
    states[310] = new State(-703);
    states[311] = new State(-704);
    states[312] = new State(-705);
    states[313] = new State(-706);
    states[314] = new State(-707);
    states[315] = new State(new int[]{6,34,5,316,118,-630,123,-630,121,-630,119,-630,122,-630,120,-630,135,-630,16,-630,90,-630,10,-630,96,-630,99,-630,31,-630,102,-630,2,-630,98,-630,12,-630,9,-630,97,-630,30,-630,84,-630,83,-630,82,-630,81,-630,80,-630,85,-630,13,-630,75,-630});
    states[316] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,5,-690,90,-690,10,-690,96,-690,99,-690,31,-690,102,-690,2,-690,98,-690,12,-690,9,-690,97,-690,30,-690,83,-690,82,-690,81,-690,80,-690,6,-690},new int[]{-111,317,-102,564,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,563,-263,540});
    states[317] = new State(new int[]{5,318,90,-693,10,-693,96,-693,99,-693,31,-693,102,-693,2,-693,98,-693,12,-693,9,-693,97,-693,30,-693,84,-693,83,-693,82,-693,81,-693,80,-693,85,-693,6,-693,75,-693});
    states[318] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456},new int[]{-102,319,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,563,-263,540});
    states[319] = new State(new int[]{6,34,90,-695,10,-695,96,-695,99,-695,31,-695,102,-695,2,-695,98,-695,12,-695,9,-695,97,-695,30,-695,84,-695,83,-695,82,-695,81,-695,80,-695,85,-695,75,-695});
    states[320] = new State(new int[]{114,321,113,322,126,323,127,324,124,325,6,-708,5,-708,118,-708,123,-708,121,-708,119,-708,122,-708,120,-708,135,-708,16,-708,90,-708,10,-708,96,-708,99,-708,31,-708,102,-708,2,-708,98,-708,12,-708,9,-708,97,-708,30,-708,84,-708,83,-708,82,-708,81,-708,80,-708,85,-708,13,-708,75,-708,49,-708,56,-708,139,-708,141,-708,79,-708,77,-708,43,-708,40,-708,8,-708,19,-708,20,-708,142,-708,144,-708,143,-708,152,-708,155,-708,154,-708,153,-708,55,-708,89,-708,38,-708,23,-708,95,-708,52,-708,33,-708,53,-708,100,-708,45,-708,34,-708,51,-708,58,-708,73,-708,71,-708,36,-708,69,-708,70,-708,136,-708,134,-708,116,-708,115,-708,129,-708,130,-708,131,-708,132,-708,128,-708},new int[]{-193,36});
    states[321] = new State(-713);
    states[322] = new State(-714);
    states[323] = new State(-715);
    states[324] = new State(-716);
    states[325] = new State(-717);
    states[326] = new State(new int[]{136,327,134,1444,116,1447,115,1448,129,1449,130,1450,131,1451,132,1452,128,1453,114,-710,113,-710,126,-710,127,-710,124,-710,6,-710,5,-710,118,-710,123,-710,121,-710,119,-710,122,-710,120,-710,135,-710,16,-710,90,-710,10,-710,96,-710,99,-710,31,-710,102,-710,2,-710,98,-710,12,-710,9,-710,97,-710,30,-710,84,-710,83,-710,82,-710,81,-710,80,-710,85,-710,13,-710,75,-710,49,-710,56,-710,139,-710,141,-710,79,-710,77,-710,43,-710,40,-710,8,-710,19,-710,20,-710,142,-710,144,-710,143,-710,152,-710,155,-710,154,-710,153,-710,55,-710,89,-710,38,-710,23,-710,95,-710,52,-710,33,-710,53,-710,100,-710,45,-710,34,-710,51,-710,58,-710,73,-710,71,-710,36,-710,69,-710,70,-710},new int[]{-194,38});
    states[327] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,22,330},new int[]{-280,328,-274,329,-176,164,-143,201,-147,48,-148,51,-266,504});
    states[328] = new State(-724);
    states[329] = new State(-725);
    states[330] = new State(new int[]{11,331,56,1442});
    states[331] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,660,12,-280,98,-280},new int[]{-160,332,-267,1441,-268,1440,-90,177,-103,284,-104,285,-176,485,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152});
    states[332] = new State(new int[]{12,333,98,1438});
    states[333] = new State(new int[]{56,334});
    states[334] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-272,335,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[335] = new State(-274);
    states[336] = new State(new int[]{13,337,118,-226,98,-226,9,-226,119,-226,8,-226,136,-226,134,-226,116,-226,115,-226,129,-226,130,-226,131,-226,132,-226,128,-226,114,-226,113,-226,126,-226,127,-226,124,-226,6,-226,5,-226,123,-226,121,-226,122,-226,120,-226,135,-226,16,-226,90,-226,10,-226,96,-226,99,-226,31,-226,102,-226,2,-226,12,-226,97,-226,30,-226,84,-226,83,-226,82,-226,81,-226,80,-226,85,-226,75,-226,49,-226,56,-226,139,-226,141,-226,79,-226,77,-226,43,-226,40,-226,19,-226,20,-226,142,-226,144,-226,143,-226,152,-226,155,-226,154,-226,153,-226,55,-226,89,-226,38,-226,23,-226,95,-226,52,-226,33,-226,53,-226,100,-226,45,-226,34,-226,51,-226,58,-226,73,-226,71,-226,36,-226,69,-226,70,-226,125,-226,108,-226});
    states[337] = new State(-224);
    states[338] = new State(new int[]{11,339,7,-813,125,-813,121,-813,8,-813,116,-813,115,-813,129,-813,130,-813,131,-813,132,-813,128,-813,6,-813,114,-813,113,-813,126,-813,127,-813,13,-813,118,-813,98,-813,9,-813,119,-813,136,-813,134,-813,124,-813,5,-813,123,-813,122,-813,120,-813,135,-813,16,-813,90,-813,10,-813,96,-813,99,-813,31,-813,102,-813,2,-813,12,-813,97,-813,30,-813,84,-813,83,-813,82,-813,81,-813,80,-813,85,-813,75,-813,49,-813,56,-813,139,-813,141,-813,79,-813,77,-813,43,-813,40,-813,19,-813,20,-813,142,-813,144,-813,143,-813,152,-813,155,-813,154,-813,153,-813,55,-813,89,-813,38,-813,23,-813,95,-813,52,-813,33,-813,53,-813,100,-813,45,-813,34,-813,51,-813,58,-813,73,-813,71,-813,36,-813,69,-813,70,-813,108,-813});
    states[339] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160},new int[]{-87,340,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840});
    states[340] = new State(new int[]{12,341,13,189,16,193});
    states[341] = new State(-284);
    states[342] = new State(-156);
    states[343] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559,12,-795},new int[]{-68,344,-75,346,-89,356,-85,349,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558});
    states[344] = new State(new int[]{12,345});
    states[345] = new State(-164);
    states[346] = new State(new int[]{98,347,12,-794,75,-794});
    states[347] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559},new int[]{-89,348,-85,349,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558});
    states[348] = new State(-797);
    states[349] = new State(new int[]{6,350,98,-798,12,-798,75,-798});
    states[350] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559},new int[]{-85,351,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558});
    states[351] = new State(-799);
    states[352] = new State(-729);
    states[353] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559,12,-795},new int[]{-68,354,-75,346,-89,356,-85,349,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558});
    states[354] = new State(new int[]{12,355});
    states[355] = new State(-750);
    states[356] = new State(-796);
    states[357] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,53,43,385,40,423,8,425,19,264,20,269,75,456},new int[]{-93,358,-15,359,-161,147,-163,148,-162,152,-16,154,-57,159,-195,360,-109,366,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462});
    states[358] = new State(-751);
    states[359] = new State(new int[]{7,44,136,-748,134,-748,116,-748,115,-748,129,-748,130,-748,131,-748,132,-748,128,-748,114,-748,113,-748,126,-748,127,-748,124,-748,6,-748,5,-748,118,-748,123,-748,121,-748,119,-748,122,-748,120,-748,135,-748,16,-748,90,-748,10,-748,96,-748,99,-748,31,-748,102,-748,2,-748,98,-748,12,-748,9,-748,97,-748,30,-748,84,-748,83,-748,82,-748,81,-748,80,-748,85,-748,13,-748,75,-748,49,-748,56,-748,139,-748,141,-748,79,-748,77,-748,43,-748,40,-748,8,-748,19,-748,20,-748,142,-748,144,-748,143,-748,152,-748,155,-748,154,-748,153,-748,55,-748,89,-748,38,-748,23,-748,95,-748,52,-748,33,-748,53,-748,100,-748,45,-748,34,-748,51,-748,58,-748,73,-748,71,-748,36,-748,69,-748,70,-748,11,-772,17,-772});
    states[360] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,53,43,385,40,423,8,425,19,264,20,269,75,456},new int[]{-93,361,-15,359,-161,147,-163,148,-162,152,-16,154,-57,159,-195,360,-109,366,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462});
    states[361] = new State(-752);
    states[362] = new State(-166);
    states[363] = new State(-167);
    states[364] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,53,43,385,40,423,8,425,19,264,20,269,75,456},new int[]{-93,365,-15,359,-161,147,-163,148,-162,152,-16,154,-57,159,-195,360,-109,366,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462});
    states[365] = new State(-753);
    states[366] = new State(-754);
    states[367] = new State(new int[]{139,1437,141,47,84,49,85,50,79,52,77,53,43,385,40,423,8,425,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456},new int[]{-108,368,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698});
    states[368] = new State(new int[]{8,369,7,380,140,415,4,416,108,-760,109,-760,110,-760,111,-760,112,-760,90,-760,10,-760,96,-760,99,-760,31,-760,102,-760,2,-760,136,-760,134,-760,116,-760,115,-760,129,-760,130,-760,131,-760,132,-760,128,-760,114,-760,113,-760,126,-760,127,-760,124,-760,6,-760,5,-760,118,-760,123,-760,121,-760,119,-760,122,-760,120,-760,135,-760,16,-760,98,-760,12,-760,9,-760,97,-760,30,-760,84,-760,83,-760,82,-760,81,-760,80,-760,85,-760,13,-760,117,-760,75,-760,49,-760,56,-760,139,-760,141,-760,79,-760,77,-760,43,-760,40,-760,19,-760,20,-760,142,-760,144,-760,143,-760,152,-760,155,-760,154,-760,153,-760,55,-760,89,-760,38,-760,23,-760,95,-760,52,-760,33,-760,53,-760,100,-760,45,-760,34,-760,51,-760,58,-760,73,-760,71,-760,36,-760,69,-760,70,-760,11,-771,17,-771});
    states[369] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,652,8,445,19,264,20,269,75,456,38,550,5,559,18,669,35,678,42,684,9,-793},new int[]{-67,370,-70,372,-86,438,-85,27,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558,-319,653,-97,654,-320,677});
    states[370] = new State(new int[]{9,371});
    states[371] = new State(-787);
    states[372] = new State(new int[]{98,373,12,-792,9,-792});
    states[373] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,652,8,445,19,264,20,269,75,456,38,550,5,559,18,669,35,678,42,684},new int[]{-86,374,-85,27,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558,-319,653,-97,654,-320,677});
    states[374] = new State(-587);
    states[375] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,53,43,385,40,423,8,425,19,264,20,269,75,456},new int[]{-93,361,-264,376,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-94,465});
    states[376] = new State(-728);
    states[377] = new State(new int[]{136,-754,134,-754,116,-754,115,-754,129,-754,130,-754,131,-754,132,-754,128,-754,114,-754,113,-754,126,-754,127,-754,124,-754,6,-754,5,-754,118,-754,123,-754,121,-754,119,-754,122,-754,120,-754,135,-754,16,-754,90,-754,10,-754,96,-754,99,-754,31,-754,102,-754,2,-754,98,-754,12,-754,9,-754,97,-754,30,-754,84,-754,83,-754,82,-754,81,-754,80,-754,85,-754,13,-754,75,-754,49,-754,56,-754,139,-754,141,-754,79,-754,77,-754,43,-754,40,-754,8,-754,19,-754,20,-754,142,-754,144,-754,143,-754,152,-754,155,-754,154,-754,153,-754,55,-754,89,-754,38,-754,23,-754,95,-754,52,-754,33,-754,53,-754,100,-754,45,-754,34,-754,51,-754,58,-754,73,-754,71,-754,36,-754,69,-754,70,-754,117,-746});
    states[378] = new State(-763);
    states[379] = new State(new int[]{8,369,7,380,140,415,4,416,15,418,136,-761,134,-761,116,-761,115,-761,129,-761,130,-761,131,-761,132,-761,128,-761,114,-761,113,-761,126,-761,127,-761,124,-761,6,-761,5,-761,118,-761,123,-761,121,-761,119,-761,122,-761,120,-761,135,-761,16,-761,90,-761,10,-761,96,-761,99,-761,31,-761,102,-761,2,-761,98,-761,12,-761,9,-761,97,-761,30,-761,84,-761,83,-761,82,-761,81,-761,80,-761,85,-761,13,-761,117,-761,75,-761,49,-761,56,-761,139,-761,141,-761,79,-761,77,-761,43,-761,40,-761,19,-761,20,-761,142,-761,144,-761,143,-761,152,-761,155,-761,154,-761,153,-761,55,-761,89,-761,38,-761,23,-761,95,-761,52,-761,33,-761,53,-761,100,-761,45,-761,34,-761,51,-761,58,-761,73,-761,71,-761,36,-761,69,-761,70,-761,11,-771,17,-771});
    states[380] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,83,56,82,57,81,58,80,59,67,60,62,61,126,62,20,63,19,64,61,65,21,66,127,67,128,68,129,69,130,70,131,71,132,72,133,73,134,74,135,75,136,76,22,77,72,78,89,79,23,80,24,81,27,82,28,83,29,84,70,85,97,86,30,87,90,88,31,89,32,90,25,91,102,92,99,93,33,94,34,95,35,96,38,97,39,98,40,99,101,100,41,101,42,102,44,103,45,104,46,105,95,106,47,107,100,108,48,109,26,110,49,111,69,112,96,113,50,114,51,115,52,116,53,117,54,118,55,119,56,120,57,121,59,122,103,123,104,124,107,125,105,126,106,127,60,128,73,129,36,130,37,131,68,132,145,133,58,134,137,135,138,136,78,137,150,138,149,139,71,140,151,141,147,142,148,143,146,144,43,385},new int[]{-144,381,-143,382,-147,48,-148,51,-289,383,-146,55,-187,384});
    states[381] = new State(-788);
    states[382] = new State(-819);
    states[383] = new State(-820);
    states[384] = new State(-821);
    states[385] = new State(new int[]{113,387,114,388,115,389,116,390,118,391,119,392,120,393,121,394,122,395,123,396,126,397,127,398,128,399,129,400,130,401,131,402,132,403,133,404,135,405,137,406,138,407,108,409,109,410,110,411,111,412,112,413,117,414},new int[]{-196,386,-190,408});
    states[386] = new State(-806);
    states[387] = new State(-927);
    states[388] = new State(-928);
    states[389] = new State(-929);
    states[390] = new State(-930);
    states[391] = new State(-931);
    states[392] = new State(-932);
    states[393] = new State(-933);
    states[394] = new State(-934);
    states[395] = new State(-935);
    states[396] = new State(-936);
    states[397] = new State(-937);
    states[398] = new State(-938);
    states[399] = new State(-939);
    states[400] = new State(-940);
    states[401] = new State(-941);
    states[402] = new State(-942);
    states[403] = new State(-943);
    states[404] = new State(-944);
    states[405] = new State(-945);
    states[406] = new State(-946);
    states[407] = new State(-947);
    states[408] = new State(-948);
    states[409] = new State(-950);
    states[410] = new State(-951);
    states[411] = new State(-952);
    states[412] = new State(-953);
    states[413] = new State(-954);
    states[414] = new State(-949);
    states[415] = new State(-790);
    states[416] = new State(new int[]{121,170},new int[]{-295,417});
    states[417] = new State(-791);
    states[418] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,43,385,40,423,8,425,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456},new int[]{-108,419,-112,420,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698});
    states[419] = new State(new int[]{8,369,7,380,140,415,4,416,15,418,108,-758,109,-758,110,-758,111,-758,112,-758,90,-758,10,-758,96,-758,99,-758,31,-758,102,-758,2,-758,136,-758,134,-758,116,-758,115,-758,129,-758,130,-758,131,-758,132,-758,128,-758,114,-758,113,-758,126,-758,127,-758,124,-758,6,-758,5,-758,118,-758,123,-758,121,-758,119,-758,122,-758,120,-758,135,-758,16,-758,98,-758,12,-758,9,-758,97,-758,30,-758,84,-758,83,-758,82,-758,81,-758,80,-758,85,-758,13,-758,117,-758,75,-758,49,-758,56,-758,139,-758,141,-758,79,-758,77,-758,43,-758,40,-758,19,-758,20,-758,142,-758,144,-758,143,-758,152,-758,155,-758,154,-758,153,-758,55,-758,89,-758,38,-758,23,-758,95,-758,52,-758,33,-758,53,-758,100,-758,45,-758,34,-758,51,-758,58,-758,73,-758,71,-758,36,-758,69,-758,70,-758,11,-771,17,-771});
    states[420] = new State(-759);
    states[421] = new State(-776);
    states[422] = new State(-777);
    states[423] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-143,424,-147,48,-148,51});
    states[424] = new State(-778);
    states[425] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559,51,702,18,669},new int[]{-85,426,-356,428,-99,568,-98,700,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558,-355,701,-97,707});
    states[426] = new State(new int[]{9,427});
    states[427] = new State(-779);
    states[428] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559,51,702},new int[]{-85,429,-355,431,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558});
    states[429] = new State(new int[]{9,430});
    states[430] = new State(-780);
    states[431] = new State(-775);
    states[432] = new State(-781);
    states[433] = new State(-782);
    states[434] = new State(new int[]{11,435,17,1434});
    states[435] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,652,8,445,19,264,20,269,75,456,38,550,5,559,18,669,35,678,42,684},new int[]{-70,436,-86,438,-85,27,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558,-319,653,-97,654,-320,677});
    states[436] = new State(new int[]{12,437,98,373});
    states[437] = new State(-784);
    states[438] = new State(-586);
    states[439] = new State(new int[]{125,440,8,-776,7,-776,140,-776,4,-776,15,-776,136,-776,134,-776,116,-776,115,-776,129,-776,130,-776,131,-776,132,-776,128,-776,114,-776,113,-776,126,-776,127,-776,124,-776,6,-776,5,-776,118,-776,123,-776,121,-776,119,-776,122,-776,120,-776,135,-776,16,-776,90,-776,10,-776,96,-776,99,-776,31,-776,102,-776,2,-776,98,-776,12,-776,9,-776,97,-776,30,-776,84,-776,83,-776,82,-776,81,-776,80,-776,85,-776,13,-776,117,-776,11,-776,17,-776});
    states[440] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,445,19,264,20,269,75,456,18,669,35,678,42,684,89,17,38,712,52,748,95,743,33,753,34,779,71,850,23,727,100,769,58,858,45,776,73,972},new int[]{-325,441,-101,442,-96,443,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,682,-113,542,-319,683,-97,654,-320,677,-327,844,-251,710,-149,711,-315,845,-243,846,-120,847,-119,848,-121,849,-35,967,-298,968,-165,969,-244,970,-122,971});
    states[441] = new State(-964);
    states[442] = new State(-1000);
    states[443] = new State(new int[]{16,30,90,-604,10,-604,96,-604,99,-604,31,-604,102,-604,2,-604,98,-604,12,-604,9,-604,97,-604,30,-604,84,-604,83,-604,82,-604,81,-604,80,-604,85,-604,13,-598});
    states[444] = new State(new int[]{6,34,118,-630,123,-630,121,-630,119,-630,122,-630,120,-630,135,-630,16,-630,90,-630,10,-630,96,-630,99,-630,31,-630,102,-630,2,-630,98,-630,12,-630,9,-630,97,-630,30,-630,84,-630,83,-630,82,-630,81,-630,80,-630,85,-630,13,-630,75,-630,5,-630,49,-630,56,-630,139,-630,141,-630,79,-630,77,-630,43,-630,40,-630,8,-630,19,-630,20,-630,142,-630,144,-630,143,-630,152,-630,155,-630,154,-630,153,-630,55,-630,89,-630,38,-630,23,-630,95,-630,52,-630,33,-630,53,-630,100,-630,45,-630,34,-630,51,-630,58,-630,73,-630,71,-630,36,-630,69,-630,70,-630,114,-630,113,-630,126,-630,127,-630,124,-630,136,-630,134,-630,116,-630,115,-630,129,-630,130,-630,131,-630,132,-630,128,-630});
    states[445] = new State(new int[]{9,1411,54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559,51,702,18,669},new int[]{-85,426,-356,428,-99,446,-143,1415,-98,700,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558,-355,701,-97,707});
    states[446] = new State(new int[]{98,447});
    states[447] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,18,669},new int[]{-77,448,-99,1099,-98,1098,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-97,707});
    states[448] = new State(new int[]{98,1096,5,582,10,-984,9,-984},new int[]{-321,449});
    states[449] = new State(new int[]{10,574,9,-972},new int[]{-328,450});
    states[450] = new State(new int[]{9,451});
    states[451] = new State(new int[]{5,656,7,-744,136,-744,134,-744,116,-744,115,-744,129,-744,130,-744,131,-744,132,-744,128,-744,114,-744,113,-744,126,-744,127,-744,124,-744,6,-744,118,-744,123,-744,121,-744,119,-744,122,-744,120,-744,135,-744,16,-744,90,-744,10,-744,96,-744,99,-744,31,-744,102,-744,2,-744,98,-744,12,-744,9,-744,97,-744,30,-744,84,-744,83,-744,82,-744,81,-744,80,-744,85,-744,13,-744,125,-986},new int[]{-332,452,-322,453});
    states[452] = new State(-969);
    states[453] = new State(new int[]{125,454});
    states[454] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,445,19,264,20,269,75,456,18,669,35,678,42,684,89,17,38,712,52,748,95,743,33,753,34,779,71,850,23,727,100,769,58,858,45,776,73,972},new int[]{-325,455,-101,442,-96,443,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,682,-113,542,-319,683,-97,654,-320,677,-327,844,-251,710,-149,711,-315,845,-243,846,-120,847,-119,848,-121,849,-35,967,-298,968,-165,969,-244,970,-122,971});
    states[455] = new State(-974);
    states[456] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559},new int[]{-68,457,-75,346,-89,356,-85,349,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558});
    states[457] = new State(new int[]{75,458});
    states[458] = new State(-786);
    states[459] = new State(new int[]{7,460,136,-755,134,-755,116,-755,115,-755,129,-755,130,-755,131,-755,132,-755,128,-755,114,-755,113,-755,126,-755,127,-755,124,-755,6,-755,5,-755,118,-755,123,-755,121,-755,119,-755,122,-755,120,-755,135,-755,16,-755,90,-755,10,-755,96,-755,99,-755,31,-755,102,-755,2,-755,98,-755,12,-755,9,-755,97,-755,30,-755,84,-755,83,-755,82,-755,81,-755,80,-755,85,-755,13,-755,75,-755,49,-755,56,-755,139,-755,141,-755,79,-755,77,-755,43,-755,40,-755,8,-755,19,-755,20,-755,142,-755,144,-755,143,-755,152,-755,155,-755,154,-755,153,-755,55,-755,89,-755,38,-755,23,-755,95,-755,52,-755,33,-755,53,-755,100,-755,45,-755,34,-755,51,-755,58,-755,73,-755,71,-755,36,-755,69,-755,70,-755});
    states[460] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,83,56,82,57,81,58,80,59,67,60,62,61,126,62,20,63,19,64,61,65,21,66,127,67,128,68,129,69,130,70,131,71,132,72,133,73,134,74,135,75,136,76,22,77,72,78,89,79,23,80,24,81,27,82,28,83,29,84,70,85,97,86,30,87,90,88,31,89,32,90,25,91,102,92,99,93,33,94,34,95,35,96,38,97,39,98,40,99,101,100,41,101,42,102,44,103,45,104,46,105,95,106,47,107,100,108,48,109,26,110,49,111,69,112,96,113,50,114,51,115,52,116,53,117,54,118,55,119,56,120,57,121,59,122,103,123,104,124,107,125,105,126,106,127,60,128,73,129,36,130,37,131,68,132,145,133,58,134,137,135,138,136,78,137,150,138,149,139,71,140,151,141,147,142,148,143,146,144,43,385},new int[]{-144,461,-143,382,-147,48,-148,51,-289,383,-146,55,-187,384});
    states[461] = new State(-789);
    states[462] = new State(-762);
    states[463] = new State(-730);
    states[464] = new State(-731);
    states[465] = new State(new int[]{117,466});
    states[466] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,53,43,385,40,423,8,425,19,264,20,269,75,456},new int[]{-93,467,-264,468,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-94,465});
    states[467] = new State(-726);
    states[468] = new State(-727);
    states[469] = new State(-735);
    states[470] = new State(new int[]{8,471,136,-720,134,-720,116,-720,115,-720,129,-720,130,-720,131,-720,132,-720,128,-720,114,-720,113,-720,126,-720,127,-720,124,-720,6,-720,5,-720,118,-720,123,-720,121,-720,119,-720,122,-720,120,-720,135,-720,16,-720,90,-720,10,-720,96,-720,99,-720,31,-720,102,-720,2,-720,98,-720,12,-720,9,-720,97,-720,30,-720,84,-720,83,-720,82,-720,81,-720,80,-720,85,-720,13,-720,75,-720,49,-720,56,-720,139,-720,141,-720,79,-720,77,-720,43,-720,40,-720,19,-720,20,-720,142,-720,144,-720,143,-720,152,-720,155,-720,154,-720,153,-720,55,-720,89,-720,38,-720,23,-720,95,-720,52,-720,33,-720,53,-720,100,-720,45,-720,34,-720,51,-720,58,-720,73,-720,71,-720,36,-720,69,-720,70,-720});
    states[471] = new State(new int[]{14,476,142,150,144,151,143,153,152,155,155,156,154,157,153,158,51,478,141,47,84,49,85,50,79,52,77,53,11,912,8,925},new int[]{-350,472,-348,1410,-15,477,-161,147,-163,148,-162,152,-16,154,-337,1401,-280,1402,-176,164,-143,201,-147,48,-148,51,-340,1408,-341,1409});
    states[472] = new State(new int[]{9,473,10,474,98,1406});
    states[473] = new State(-633);
    states[474] = new State(new int[]{14,476,142,150,144,151,143,153,152,155,155,156,154,157,153,158,51,478,141,47,84,49,85,50,79,52,77,53,11,912,8,925},new int[]{-348,475,-15,477,-161,147,-163,148,-162,152,-16,154,-337,1401,-280,1402,-176,164,-143,201,-147,48,-148,51,-340,1408,-341,1409});
    states[475] = new State(-670);
    states[476] = new State(-672);
    states[477] = new State(-673);
    states[478] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-143,479,-147,48,-148,51});
    states[479] = new State(new int[]{5,480,9,-675,10,-675,98,-675});
    states[480] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-272,481,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[481] = new State(-674);
    states[482] = new State(-255);
    states[483] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153},new int[]{-104,484,-176,485,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152});
    states[484] = new State(new int[]{8,182,116,-256,115,-256,129,-256,130,-256,131,-256,132,-256,128,-256,6,-256,114,-256,113,-256,126,-256,127,-256,13,-256,119,-256,98,-256,118,-256,9,-256,136,-256,134,-256,124,-256,5,-256,123,-256,121,-256,122,-256,120,-256,135,-256,16,-256,90,-256,10,-256,96,-256,99,-256,31,-256,102,-256,2,-256,12,-256,97,-256,30,-256,84,-256,83,-256,82,-256,81,-256,80,-256,85,-256,75,-256,49,-256,56,-256,139,-256,141,-256,79,-256,77,-256,43,-256,40,-256,19,-256,20,-256,142,-256,144,-256,143,-256,152,-256,155,-256,154,-256,153,-256,55,-256,89,-256,38,-256,23,-256,95,-256,52,-256,33,-256,53,-256,100,-256,45,-256,34,-256,51,-256,58,-256,73,-256,71,-256,36,-256,69,-256,70,-256,125,-256,108,-256});
    states[485] = new State(new int[]{7,165,8,-254,116,-254,115,-254,129,-254,130,-254,131,-254,132,-254,128,-254,6,-254,114,-254,113,-254,126,-254,127,-254,13,-254,119,-254,98,-254,118,-254,9,-254,136,-254,134,-254,124,-254,5,-254,123,-254,121,-254,122,-254,120,-254,135,-254,16,-254,90,-254,10,-254,96,-254,99,-254,31,-254,102,-254,2,-254,12,-254,97,-254,30,-254,84,-254,83,-254,82,-254,81,-254,80,-254,85,-254,75,-254,49,-254,56,-254,139,-254,141,-254,79,-254,77,-254,43,-254,40,-254,19,-254,20,-254,142,-254,144,-254,143,-254,152,-254,155,-254,154,-254,153,-254,55,-254,89,-254,38,-254,23,-254,95,-254,52,-254,33,-254,53,-254,100,-254,45,-254,34,-254,51,-254,58,-254,73,-254,71,-254,36,-254,69,-254,70,-254,125,-254,108,-254});
    states[486] = new State(-257);
    states[487] = new State(new int[]{9,488,141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-78,295,-76,301,-272,304,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[488] = new State(new int[]{125,291});
    states[489] = new State(-227);
    states[490] = new State(new int[]{13,491,125,492,118,-232,98,-232,9,-232,119,-232,8,-232,136,-232,134,-232,116,-232,115,-232,129,-232,130,-232,131,-232,132,-232,128,-232,114,-232,113,-232,126,-232,127,-232,124,-232,6,-232,5,-232,123,-232,121,-232,122,-232,120,-232,135,-232,16,-232,90,-232,10,-232,96,-232,99,-232,31,-232,102,-232,2,-232,12,-232,97,-232,30,-232,84,-232,83,-232,82,-232,81,-232,80,-232,85,-232,75,-232,49,-232,56,-232,139,-232,141,-232,79,-232,77,-232,43,-232,40,-232,19,-232,20,-232,142,-232,144,-232,143,-232,152,-232,155,-232,154,-232,153,-232,55,-232,89,-232,38,-232,23,-232,95,-232,52,-232,33,-232,53,-232,100,-232,45,-232,34,-232,51,-232,58,-232,73,-232,71,-232,36,-232,69,-232,70,-232,108,-232});
    states[491] = new State(-225);
    states[492] = new State(new int[]{8,494,141,47,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-275,493,-268,175,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-277,1398,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,1399,-220,599,-219,600,-297,1400});
    states[493] = new State(-290);
    states[494] = new State(new int[]{9,495,141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-78,295,-76,301,-272,304,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[495] = new State(new int[]{125,291,119,-294,98,-294,118,-294,9,-294,8,-294,136,-294,134,-294,116,-294,115,-294,129,-294,130,-294,131,-294,132,-294,128,-294,114,-294,113,-294,126,-294,127,-294,124,-294,6,-294,5,-294,123,-294,121,-294,122,-294,120,-294,135,-294,16,-294,90,-294,10,-294,96,-294,99,-294,31,-294,102,-294,2,-294,12,-294,97,-294,30,-294,84,-294,83,-294,82,-294,81,-294,80,-294,85,-294,13,-294,75,-294,49,-294,56,-294,139,-294,141,-294,79,-294,77,-294,43,-294,40,-294,19,-294,20,-294,142,-294,144,-294,143,-294,152,-294,155,-294,154,-294,153,-294,55,-294,89,-294,38,-294,23,-294,95,-294,52,-294,33,-294,53,-294,100,-294,45,-294,34,-294,51,-294,58,-294,73,-294,71,-294,36,-294,69,-294,70,-294,108,-294});
    states[496] = new State(-228);
    states[497] = new State(-229);
    states[498] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-271,499,-272,500,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[499] = new State(-265);
    states[500] = new State(-479);
    states[501] = new State(-230);
    states[502] = new State(-266);
    states[503] = new State(-268);
    states[504] = new State(-275);
    states[505] = new State(-269);
    states[506] = new State(new int[]{8,1274,21,-316,11,-316,90,-316,83,-316,82,-316,81,-316,80,-316,27,-316,141,-316,84,-316,85,-316,79,-316,77,-316,60,-316,26,-316,24,-316,42,-316,35,-316,28,-316,29,-316,44,-316,25,-316},new int[]{-179,507});
    states[507] = new State(new int[]{21,1265,11,-323,90,-323,83,-323,82,-323,81,-323,80,-323,27,-323,141,-323,84,-323,85,-323,79,-323,77,-323,60,-323,26,-323,24,-323,42,-323,35,-323,28,-323,29,-323,44,-323,25,-323},new int[]{-314,508,-313,1263,-312,1285});
    states[508] = new State(new int[]{11,640,90,-340,83,-340,82,-340,81,-340,80,-340,27,-211,141,-211,84,-211,85,-211,79,-211,77,-211,60,-211,26,-211,24,-211,42,-211,35,-211,28,-211,29,-211,44,-211,25,-211},new int[]{-25,509,-32,1243,-34,513,-45,1244,-6,1245,-246,1094,-33,1354,-54,1356,-53,519,-55,1355});
    states[509] = new State(new int[]{90,510,83,1239,82,1240,81,1241,80,1242},new int[]{-7,511});
    states[510] = new State(-298);
    states[511] = new State(new int[]{11,640,90,-340,83,-340,82,-340,81,-340,80,-340,27,-211,141,-211,84,-211,85,-211,79,-211,77,-211,60,-211,26,-211,24,-211,42,-211,35,-211,28,-211,29,-211,44,-211,25,-211},new int[]{-32,512,-34,513,-45,1244,-6,1245,-246,1094,-33,1354,-54,1356,-53,519,-55,1355});
    states[512] = new State(-335);
    states[513] = new State(new int[]{10,515,90,-346,83,-346,82,-346,81,-346,80,-346},new int[]{-186,514});
    states[514] = new State(-341);
    states[515] = new State(new int[]{11,640,90,-347,83,-347,82,-347,81,-347,80,-347,27,-211,141,-211,84,-211,85,-211,79,-211,77,-211,60,-211,26,-211,24,-211,42,-211,35,-211,28,-211,29,-211,44,-211,25,-211},new int[]{-45,516,-33,517,-6,1245,-246,1094,-54,1356,-53,519,-55,1355});
    states[516] = new State(-349);
    states[517] = new State(new int[]{11,640,90,-343,83,-343,82,-343,81,-343,80,-343,26,-211,24,-211,42,-211,35,-211,28,-211,29,-211,44,-211,25,-211},new int[]{-54,518,-53,519,-6,520,-246,1094,-55,1355});
    states[518] = new State(-352);
    states[519] = new State(-353);
    states[520] = new State(new int[]{26,1310,24,1311,42,1258,35,1293,28,1325,29,1332,11,640,44,1339,25,1348},new int[]{-218,521,-246,522,-215,523,-254,524,-3,525,-226,1312,-224,1187,-221,1257,-225,1292,-223,1313,-211,1336,-212,1337,-214,1338});
    states[521] = new State(-362);
    states[522] = new State(-210);
    states[523] = new State(-363);
    states[524] = new State(-377);
    states[525] = new State(new int[]{28,527,44,1141,25,1179,42,1258,35,1293},new int[]{-226,526,-212,1140,-224,1187,-221,1257,-225,1292});
    states[526] = new State(-366);
    states[527] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,43,385,8,-376,108,-376,10,-376},new int[]{-168,528,-167,1123,-166,1124,-138,1125,-133,1126,-130,1127,-143,1132,-147,48,-148,51,-187,1133,-331,1135,-145,1139});
    states[528] = new State(new int[]{8,603,108,-463,10,-463},new int[]{-124,529});
    states[529] = new State(new int[]{108,531,10,1112},new int[]{-203,530});
    states[530] = new State(-373);
    states[531] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,10,-487},new int[]{-256,532,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[532] = new State(new int[]{10,533});
    states[533] = new State(-421);
    states[534] = new State(new int[]{8,369,7,380,140,415,4,416,15,418,17,535,108,-761,109,-761,110,-761,111,-761,112,-761,90,-761,10,-761,96,-761,99,-761,31,-761,102,-761,2,-761,98,-761,12,-761,9,-761,97,-761,30,-761,84,-761,83,-761,82,-761,81,-761,80,-761,85,-761,136,-761,134,-761,116,-761,115,-761,129,-761,130,-761,131,-761,132,-761,128,-761,114,-761,113,-761,126,-761,127,-761,124,-761,6,-761,5,-761,118,-761,123,-761,121,-761,119,-761,122,-761,120,-761,135,-761,16,-761,13,-761,117,-761,11,-771});
    states[535] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,5,559},new int[]{-116,536,-102,565,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,563,-263,540});
    states[536] = new State(new int[]{12,537});
    states[537] = new State(new int[]{108,409,109,410,110,411,111,412,112,413},new int[]{-190,538});
    states[538] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559},new int[]{-85,539,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558});
    states[539] = new State(-517);
    states[540] = new State(-721);
    states[541] = new State(new int[]{90,-596,10,-596,96,-596,99,-596,31,-596,102,-596,2,-596,98,-596,12,-596,9,-596,97,-596,30,-596,84,-596,83,-596,82,-596,81,-596,80,-596,85,-596,6,-596,75,-596,5,-596,49,-596,56,-596,139,-596,141,-596,79,-596,77,-596,43,-596,40,-596,8,-596,19,-596,20,-596,142,-596,144,-596,143,-596,152,-596,155,-596,154,-596,153,-596,55,-596,89,-596,38,-596,23,-596,95,-596,52,-596,33,-596,53,-596,100,-596,45,-596,34,-596,51,-596,58,-596,73,-596,71,-596,36,-596,69,-596,70,-596,13,-599});
    states[542] = new State(new int[]{13,543});
    states[543] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456},new int[]{-113,544,-96,547,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,548});
    states[544] = new State(new int[]{5,545,13,543});
    states[545] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456},new int[]{-113,546,-96,547,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,548});
    states[546] = new State(new int[]{13,543,90,-612,10,-612,96,-612,99,-612,31,-612,102,-612,2,-612,98,-612,12,-612,9,-612,97,-612,30,-612,84,-612,83,-612,82,-612,81,-612,80,-612,85,-612,6,-612,75,-612,5,-612,49,-612,56,-612,139,-612,141,-612,79,-612,77,-612,43,-612,40,-612,8,-612,19,-612,20,-612,142,-612,144,-612,143,-612,152,-612,155,-612,154,-612,153,-612,55,-612,89,-612,38,-612,23,-612,95,-612,52,-612,33,-612,53,-612,100,-612,45,-612,34,-612,51,-612,58,-612,73,-612,71,-612,36,-612,69,-612,70,-612});
    states[547] = new State(new int[]{16,30,5,-598,13,-598,90,-598,10,-598,96,-598,99,-598,31,-598,102,-598,2,-598,98,-598,12,-598,9,-598,97,-598,30,-598,84,-598,83,-598,82,-598,81,-598,80,-598,85,-598,6,-598,75,-598,49,-598,56,-598,139,-598,141,-598,79,-598,77,-598,43,-598,40,-598,8,-598,19,-598,20,-598,142,-598,144,-598,143,-598,152,-598,155,-598,154,-598,153,-598,55,-598,89,-598,38,-598,23,-598,95,-598,52,-598,33,-598,53,-598,100,-598,45,-598,34,-598,51,-598,58,-598,73,-598,71,-598,36,-598,69,-598,70,-598});
    states[548] = new State(-599);
    states[549] = new State(-597);
    states[550] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-114,551,-96,556,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-238,557});
    states[551] = new State(new int[]{49,552});
    states[552] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-114,553,-96,556,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-238,557});
    states[553] = new State(new int[]{30,554});
    states[554] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-114,555,-96,556,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-238,557});
    states[555] = new State(-613);
    states[556] = new State(new int[]{16,30,49,-600,30,-600,118,-600,123,-600,121,-600,119,-600,122,-600,120,-600,135,-600,90,-600,10,-600,96,-600,99,-600,31,-600,102,-600,2,-600,98,-600,12,-600,9,-600,97,-600,84,-600,83,-600,82,-600,81,-600,80,-600,85,-600,13,-600,6,-600,75,-600,5,-600,56,-600,139,-600,141,-600,79,-600,77,-600,43,-600,40,-600,8,-600,19,-600,20,-600,142,-600,144,-600,143,-600,152,-600,155,-600,154,-600,153,-600,55,-600,89,-600,38,-600,23,-600,95,-600,52,-600,33,-600,53,-600,100,-600,45,-600,34,-600,51,-600,58,-600,73,-600,71,-600,36,-600,69,-600,70,-600,114,-600,113,-600,126,-600,127,-600,124,-600,136,-600,134,-600,116,-600,115,-600,129,-600,130,-600,131,-600,132,-600,128,-600});
    states[557] = new State(-601);
    states[558] = new State(-594);
    states[559] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,5,-690,90,-690,10,-690,96,-690,99,-690,31,-690,102,-690,2,-690,98,-690,12,-690,9,-690,97,-690,30,-690,83,-690,82,-690,81,-690,80,-690,6,-690},new int[]{-111,560,-102,564,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,563,-263,540});
    states[560] = new State(new int[]{5,561,90,-694,10,-694,96,-694,99,-694,31,-694,102,-694,2,-694,98,-694,12,-694,9,-694,97,-694,30,-694,84,-694,83,-694,82,-694,81,-694,80,-694,85,-694,6,-694,75,-694});
    states[561] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456},new int[]{-102,562,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,563,-263,540});
    states[562] = new State(new int[]{6,34,90,-696,10,-696,96,-696,99,-696,31,-696,102,-696,2,-696,98,-696,12,-696,9,-696,97,-696,30,-696,84,-696,83,-696,82,-696,81,-696,80,-696,85,-696,75,-696});
    states[563] = new State(-720);
    states[564] = new State(new int[]{6,34,5,-689,90,-689,10,-689,96,-689,99,-689,31,-689,102,-689,2,-689,98,-689,12,-689,9,-689,97,-689,30,-689,84,-689,83,-689,82,-689,81,-689,80,-689,85,-689,75,-689});
    states[565] = new State(new int[]{5,316,6,34});
    states[566] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,90,-568,10,-568,96,-568,99,-568,31,-568,102,-568,2,-568,98,-568,12,-568,9,-568,97,-568,30,-568,83,-568,82,-568,81,-568,80,-568},new int[]{-143,424,-147,48,-148,51});
    states[567] = new State(new int[]{51,1100,54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559,18,669},new int[]{-85,426,-356,428,-99,568,-108,689,-98,700,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558,-355,701,-97,707});
    states[568] = new State(new int[]{98,569});
    states[569] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,18,669},new int[]{-77,570,-99,1099,-98,1098,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-97,707});
    states[570] = new State(new int[]{98,1096,5,582,10,-984,9,-984},new int[]{-321,571});
    states[571] = new State(new int[]{10,574,9,-972},new int[]{-328,572});
    states[572] = new State(new int[]{9,573});
    states[573] = new State(-744);
    states[574] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-323,575,-324,1077,-154,578,-143,796,-147,48,-148,51});
    states[575] = new State(new int[]{10,576,9,-973});
    states[576] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-324,577,-154,578,-143,796,-147,48,-148,51});
    states[577] = new State(-982);
    states[578] = new State(new int[]{98,580,5,582,10,-984,9,-984},new int[]{-321,579});
    states[579] = new State(-983);
    states[580] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-143,581,-147,48,-148,51});
    states[581] = new State(-345);
    states[582] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-271,583,-272,500,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[583] = new State(-985);
    states[584] = new State(-270);
    states[585] = new State(new int[]{56,586});
    states[586] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-272,587,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[587] = new State(-281);
    states[588] = new State(-271);
    states[589] = new State(new int[]{56,590,119,-283,98,-283,118,-283,9,-283,8,-283,136,-283,134,-283,116,-283,115,-283,129,-283,130,-283,131,-283,132,-283,128,-283,114,-283,113,-283,126,-283,127,-283,124,-283,6,-283,5,-283,123,-283,121,-283,122,-283,120,-283,135,-283,16,-283,90,-283,10,-283,96,-283,99,-283,31,-283,102,-283,2,-283,12,-283,97,-283,30,-283,84,-283,83,-283,82,-283,81,-283,80,-283,85,-283,13,-283,75,-283,49,-283,139,-283,141,-283,79,-283,77,-283,43,-283,40,-283,19,-283,20,-283,142,-283,144,-283,143,-283,152,-283,155,-283,154,-283,153,-283,55,-283,89,-283,38,-283,23,-283,95,-283,52,-283,33,-283,53,-283,100,-283,45,-283,34,-283,51,-283,58,-283,73,-283,71,-283,36,-283,69,-283,70,-283,125,-283,108,-283});
    states[590] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-272,591,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[591] = new State(-282);
    states[592] = new State(-272);
    states[593] = new State(new int[]{56,594});
    states[594] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-272,595,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[595] = new State(-273);
    states[596] = new State(new int[]{22,330,46,506,47,585,32,589,72,593},new int[]{-278,597,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592});
    states[597] = new State(-267);
    states[598] = new State(-231);
    states[599] = new State(-285);
    states[600] = new State(-286);
    states[601] = new State(new int[]{8,603,119,-463,98,-463,118,-463,9,-463,136,-463,134,-463,116,-463,115,-463,129,-463,130,-463,131,-463,132,-463,128,-463,114,-463,113,-463,126,-463,127,-463,124,-463,6,-463,5,-463,123,-463,121,-463,122,-463,120,-463,135,-463,16,-463,90,-463,10,-463,96,-463,99,-463,31,-463,102,-463,2,-463,12,-463,97,-463,30,-463,84,-463,83,-463,82,-463,81,-463,80,-463,85,-463,13,-463,75,-463,49,-463,56,-463,139,-463,141,-463,79,-463,77,-463,43,-463,40,-463,19,-463,20,-463,142,-463,144,-463,143,-463,152,-463,155,-463,154,-463,153,-463,55,-463,89,-463,38,-463,23,-463,95,-463,52,-463,33,-463,53,-463,100,-463,45,-463,34,-463,51,-463,58,-463,73,-463,71,-463,36,-463,69,-463,70,-463,125,-463,108,-463},new int[]{-124,602});
    states[602] = new State(-287);
    states[603] = new State(new int[]{9,604,11,640,141,-211,84,-211,85,-211,79,-211,77,-211,51,-211,27,-211,106,-211},new int[]{-125,605,-56,1095,-6,609,-246,1094});
    states[604] = new State(-464);
    states[605] = new State(new int[]{9,606,10,607});
    states[606] = new State(-465);
    states[607] = new State(new int[]{11,640,141,-211,84,-211,85,-211,79,-211,77,-211,51,-211,27,-211,106,-211},new int[]{-56,608,-6,609,-246,1094});
    states[608] = new State(-467);
    states[609] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,51,624,27,630,106,636,11,640},new int[]{-292,610,-246,522,-155,611,-131,623,-143,622,-147,48,-148,51});
    states[610] = new State(-468);
    states[611] = new State(new int[]{5,612,98,620});
    states[612] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-271,613,-272,500,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[613] = new State(new int[]{108,614,9,-469,10,-469});
    states[614] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559},new int[]{-85,615,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558});
    states[615] = new State(-473);
    states[616] = new State(new int[]{8,603,5,-463},new int[]{-124,617});
    states[617] = new State(new int[]{5,618});
    states[618] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-271,619,-272,500,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[619] = new State(-288);
    states[620] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-131,621,-143,622,-147,48,-148,51});
    states[621] = new State(-477);
    states[622] = new State(-478);
    states[623] = new State(-476);
    states[624] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-155,625,-131,623,-143,622,-147,48,-148,51});
    states[625] = new State(new int[]{5,626,98,620});
    states[626] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-271,627,-272,500,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[627] = new State(new int[]{108,628,9,-470,10,-470});
    states[628] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559},new int[]{-85,629,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558});
    states[629] = new State(-474);
    states[630] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-155,631,-131,623,-143,622,-147,48,-148,51});
    states[631] = new State(new int[]{5,632,98,620});
    states[632] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-271,633,-272,500,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[633] = new State(new int[]{108,634,9,-471,10,-471});
    states[634] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559},new int[]{-85,635,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558});
    states[635] = new State(-475);
    states[636] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-155,637,-131,623,-143,622,-147,48,-148,51});
    states[637] = new State(new int[]{5,638,98,620});
    states[638] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-271,639,-272,500,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[639] = new State(-472);
    states[640] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-247,641,-8,1093,-9,645,-176,646,-143,1088,-147,48,-148,51,-297,1091});
    states[641] = new State(new int[]{12,642,98,643});
    states[642] = new State(-212);
    states[643] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-8,644,-9,645,-176,646,-143,1088,-147,48,-148,51,-297,1091});
    states[644] = new State(-214);
    states[645] = new State(-215);
    states[646] = new State(new int[]{7,165,8,649,121,170,12,-628,98,-628},new int[]{-69,647,-295,648});
    states[647] = new State(-765);
    states[648] = new State(-233);
    states[649] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,652,8,445,19,264,20,269,75,456,38,550,5,559,18,669,35,678,42,684,9,-793},new int[]{-67,650,-70,372,-86,438,-85,27,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558,-319,653,-97,654,-320,677});
    states[650] = new State(new int[]{9,651});
    states[651] = new State(-629);
    states[652] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,90,-592,10,-592,96,-592,99,-592,31,-592,102,-592,2,-592,98,-592,12,-592,9,-592,97,-592,30,-592,83,-592,82,-592,81,-592,80,-592},new int[]{-143,424,-147,48,-148,51});
    states[653] = new State(-591);
    states[654] = new State(new int[]{5,656,125,-986},new int[]{-332,655,-322,453});
    states[655] = new State(-970);
    states[656] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,660,140,498,22,330,46,506,47,585,32,589,72,593,63,596},new int[]{-273,657,-268,658,-90,177,-103,284,-104,285,-176,659,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-252,665,-245,666,-277,667,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-297,668});
    states[657] = new State(-987);
    states[658] = new State(-480);
    states[659] = new State(new int[]{7,165,121,170,8,-254,116,-254,115,-254,129,-254,130,-254,131,-254,132,-254,128,-254,6,-254,114,-254,113,-254,126,-254,127,-254,125,-254},new int[]{-295,648});
    states[660] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-78,661,-76,301,-272,304,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[661] = new State(new int[]{9,662,98,663});
    states[662] = new State(-249);
    states[663] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-76,664,-272,304,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[664] = new State(-262);
    states[665] = new State(-481);
    states[666] = new State(-482);
    states[667] = new State(-483);
    states[668] = new State(-484);
    states[669] = new State(new int[]{18,669,141,47,84,49,85,50,79,52,77,53},new int[]{-24,670,-23,676,-97,674,-143,675,-147,48,-148,51});
    states[670] = new State(new int[]{98,671});
    states[671] = new State(new int[]{18,669,141,47,84,49,85,50,79,52,77,53},new int[]{-23,672,-97,674,-143,675,-147,48,-148,51});
    states[672] = new State(new int[]{9,673,98,-959});
    states[673] = new State(-955);
    states[674] = new State(-956);
    states[675] = new State(-957);
    states[676] = new State(-958);
    states[677] = new State(-971);
    states[678] = new State(new int[]{8,1078,5,656,125,-986},new int[]{-322,679});
    states[679] = new State(new int[]{125,680});
    states[680] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,445,19,264,20,269,75,456,18,669,35,678,42,684,89,17,38,712,52,748,95,743,33,753,34,779,71,850,23,727,100,769,58,858,45,776,73,972},new int[]{-325,681,-101,442,-96,443,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,682,-113,542,-319,683,-97,654,-320,677,-327,844,-251,710,-149,711,-315,845,-243,846,-120,847,-119,848,-121,849,-35,967,-298,968,-165,969,-244,970,-122,971});
    states[681] = new State(-975);
    states[682] = new State(new int[]{90,-605,10,-605,96,-605,99,-605,31,-605,102,-605,2,-605,98,-605,12,-605,9,-605,97,-605,30,-605,84,-605,83,-605,82,-605,81,-605,80,-605,85,-605,13,-599});
    states[683] = new State(-606);
    states[684] = new State(new int[]{125,685,8,1069});
    states[685] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,53,43,385,40,423,8,688,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,89,17,38,712,52,748,95,743,33,753,34,779,71,850,23,727,100,769,58,858,45,776,73,972},new int[]{-326,686,-208,687,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-4,708,-327,709,-251,710,-149,711,-315,845,-243,846,-120,847,-119,848,-121,849,-35,967,-298,968,-165,969,-244,970,-122,971});
    states[686] = new State(-978);
    states[687] = new State(-1002);
    states[688] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559,51,702,18,669},new int[]{-85,426,-356,428,-99,568,-108,689,-98,700,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558,-355,701,-97,707});
    states[689] = new State(new int[]{98,690,8,369,7,380,140,415,4,416,15,418,136,-761,134,-761,116,-761,115,-761,129,-761,130,-761,131,-761,132,-761,128,-761,114,-761,113,-761,126,-761,127,-761,124,-761,6,-761,5,-761,118,-761,123,-761,121,-761,119,-761,122,-761,120,-761,135,-761,16,-761,9,-761,13,-761,117,-761,11,-771,17,-771});
    states[690] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,43,385,40,423,8,425,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456},new int[]{-333,691,-108,699,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698});
    states[691] = new State(new int[]{9,692,98,695});
    states[692] = new State(new int[]{108,409,109,410,110,411,111,412,112,413},new int[]{-190,693});
    states[693] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559},new int[]{-85,694,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558});
    states[694] = new State(-516);
    states[695] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,43,385,40,423,8,425,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456},new int[]{-108,696,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698});
    states[696] = new State(new int[]{8,369,7,380,140,415,4,416,9,-519,98,-519,11,-771,17,-771});
    states[697] = new State(new int[]{7,44,11,-772,17,-772});
    states[698] = new State(new int[]{7,460});
    states[699] = new State(new int[]{8,369,7,380,140,415,4,416,9,-518,98,-518,11,-771,17,-771});
    states[700] = new State(new int[]{9,-593,98,-960});
    states[701] = new State(-774);
    states[702] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-143,703,-147,48,-148,51});
    states[703] = new State(new int[]{108,704});
    states[704] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559},new int[]{-85,705,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558});
    states[705] = new State(new int[]{10,706});
    states[706] = new State(-773);
    states[707] = new State(-961);
    states[708] = new State(-1003);
    states[709] = new State(-1004);
    states[710] = new State(-988);
    states[711] = new State(-989);
    states[712] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-98,713,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549});
    states[713] = new State(new int[]{49,714});
    states[714] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,90,-487,10,-487,96,-487,99,-487,31,-487,102,-487,2,-487,98,-487,12,-487,9,-487,97,-487,30,-487,83,-487,82,-487,81,-487,80,-487},new int[]{-256,715,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[715] = new State(new int[]{30,716,90,-527,10,-527,96,-527,99,-527,31,-527,102,-527,2,-527,98,-527,12,-527,9,-527,97,-527,84,-527,83,-527,82,-527,81,-527,80,-527,85,-527});
    states[716] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,90,-487,10,-487,96,-487,99,-487,31,-487,102,-487,2,-487,98,-487,12,-487,9,-487,97,-487,30,-487,83,-487,82,-487,81,-487,80,-487},new int[]{-256,717,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[717] = new State(-528);
    states[718] = new State(-489);
    states[719] = new State(-490);
    states[720] = new State(new int[]{152,722,141,47,84,49,85,50,79,52,77,53},new int[]{-139,721,-143,723,-147,48,-148,51});
    states[721] = new State(-523);
    states[722] = new State(-99);
    states[723] = new State(-100);
    states[724] = new State(-491);
    states[725] = new State(-492);
    states[726] = new State(-493);
    states[727] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-98,728,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549});
    states[728] = new State(new int[]{56,729});
    states[729] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160,30,737,90,-547},new int[]{-36,730,-249,1066,-258,1068,-72,1059,-107,1065,-91,1064,-87,188,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840});
    states[730] = new State(new int[]{10,733,30,737,90,-547},new int[]{-249,731});
    states[731] = new State(new int[]{90,732});
    states[732] = new State(-538);
    states[733] = new State(new int[]{30,737,141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160,90,-547},new int[]{-249,734,-258,736,-72,1059,-107,1065,-91,1064,-87,188,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840});
    states[734] = new State(new int[]{90,735});
    states[735] = new State(-539);
    states[736] = new State(-542);
    states[737] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,741,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,10,-487,90,-487},new int[]{-248,738,-257,739,-256,22,-4,23,-109,24,-128,367,-108,534,-143,740,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871,-139,1026});
    states[738] = new State(new int[]{10,20,90,-548});
    states[739] = new State(-525);
    states[740] = new State(new int[]{8,-776,7,-776,140,-776,4,-776,15,-776,17,-776,108,-776,109,-776,110,-776,111,-776,112,-776,90,-776,10,-776,11,-776,96,-776,99,-776,31,-776,102,-776,2,-776,5,-100});
    states[741] = new State(new int[]{7,-189,11,-189,17,-189,5,-99});
    states[742] = new State(-494);
    states[743] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,741,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,96,-487,10,-487},new int[]{-248,744,-257,739,-256,22,-4,23,-109,24,-128,367,-108,534,-143,740,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871,-139,1026});
    states[744] = new State(new int[]{96,745,10,20});
    states[745] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559},new int[]{-85,746,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558});
    states[746] = new State(-549);
    states[747] = new State(-495);
    states[748] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-98,749,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549});
    states[749] = new State(new int[]{97,1051,139,-552,141,-552,84,-552,85,-552,79,-552,77,-552,43,-552,40,-552,8,-552,19,-552,20,-552,142,-552,144,-552,143,-552,152,-552,155,-552,154,-552,153,-552,75,-552,55,-552,89,-552,38,-552,23,-552,95,-552,52,-552,33,-552,53,-552,100,-552,45,-552,34,-552,51,-552,58,-552,73,-552,71,-552,36,-552,90,-552,10,-552,96,-552,99,-552,31,-552,102,-552,2,-552,98,-552,12,-552,9,-552,30,-552,83,-552,82,-552,81,-552,80,-552},new int[]{-288,750});
    states[750] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,90,-487,10,-487,96,-487,99,-487,31,-487,102,-487,2,-487,98,-487,12,-487,9,-487,97,-487,30,-487,83,-487,82,-487,81,-487,80,-487},new int[]{-256,751,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[751] = new State(-550);
    states[752] = new State(-496);
    states[753] = new State(new int[]{51,1058,141,-562,84,-562,85,-562,79,-562,77,-562},new int[]{-19,754});
    states[754] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-143,755,-147,48,-148,51});
    states[755] = new State(new int[]{108,1054,5,1055},new int[]{-282,756});
    states[756] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-98,757,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549});
    states[757] = new State(new int[]{69,1052,70,1053},new int[]{-115,758});
    states[758] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-98,759,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549});
    states[759] = new State(new int[]{97,1051,139,-552,141,-552,84,-552,85,-552,79,-552,77,-552,43,-552,40,-552,8,-552,19,-552,20,-552,142,-552,144,-552,143,-552,152,-552,155,-552,154,-552,153,-552,75,-552,55,-552,89,-552,38,-552,23,-552,95,-552,52,-552,33,-552,53,-552,100,-552,45,-552,34,-552,51,-552,58,-552,73,-552,71,-552,36,-552,90,-552,10,-552,96,-552,99,-552,31,-552,102,-552,2,-552,98,-552,12,-552,9,-552,30,-552,83,-552,82,-552,81,-552,80,-552},new int[]{-288,760});
    states[760] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,90,-487,10,-487,96,-487,99,-487,31,-487,102,-487,2,-487,98,-487,12,-487,9,-487,97,-487,30,-487,83,-487,82,-487,81,-487,80,-487},new int[]{-256,761,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[761] = new State(-560);
    states[762] = new State(-497);
    states[763] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,652,8,445,19,264,20,269,75,456,38,550,5,559,18,669,35,678,42,684},new int[]{-70,764,-86,438,-85,27,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558,-319,653,-97,654,-320,677});
    states[764] = new State(new int[]{97,765,98,373});
    states[765] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,90,-487,10,-487,96,-487,99,-487,31,-487,102,-487,2,-487,98,-487,12,-487,9,-487,97,-487,30,-487,83,-487,82,-487,81,-487,80,-487},new int[]{-256,766,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[766] = new State(-567);
    states[767] = new State(-498);
    states[768] = new State(-499);
    states[769] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,741,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,10,-487,99,-487,31,-487},new int[]{-248,770,-257,739,-256,22,-4,23,-109,24,-128,367,-108,534,-143,740,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871,-139,1026});
    states[770] = new State(new int[]{10,20,99,772,31,1029},new int[]{-286,771});
    states[771] = new State(-569);
    states[772] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,741,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,90,-487,10,-487},new int[]{-248,773,-257,739,-256,22,-4,23,-109,24,-128,367,-108,534,-143,740,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871,-139,1026});
    states[773] = new State(new int[]{90,774,10,20});
    states[774] = new State(-570);
    states[775] = new State(-500);
    states[776] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559,90,-584,10,-584,96,-584,99,-584,31,-584,102,-584,2,-584,98,-584,12,-584,9,-584,97,-584,30,-584,83,-584,82,-584,81,-584,80,-584},new int[]{-85,777,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558});
    states[777] = new State(-585);
    states[778] = new State(-501);
    states[779] = new State(new int[]{51,1007,141,47,84,49,85,50,79,52,77,53},new int[]{-143,780,-147,48,-148,51});
    states[780] = new State(new int[]{5,1005,135,-559},new int[]{-270,781});
    states[781] = new State(new int[]{135,782});
    states[782] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-98,783,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549});
    states[783] = new State(new int[]{97,784});
    states[784] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,90,-487,10,-487,96,-487,99,-487,31,-487,102,-487,2,-487,98,-487,12,-487,9,-487,97,-487,30,-487,83,-487,82,-487,81,-487,80,-487},new int[]{-256,785,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[785] = new State(-554);
    states[786] = new State(-502);
    states[787] = new State(new int[]{8,789,141,47,84,49,85,50,79,52,77,53},new int[]{-308,788,-154,797,-143,796,-147,48,-148,51});
    states[788] = new State(-512);
    states[789] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-143,790,-147,48,-148,51});
    states[790] = new State(new int[]{98,791});
    states[791] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-154,792,-143,796,-147,48,-148,51});
    states[792] = new State(new int[]{9,793,98,580});
    states[793] = new State(new int[]{108,794});
    states[794] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559},new int[]{-85,795,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558});
    states[795] = new State(-514);
    states[796] = new State(-344);
    states[797] = new State(new int[]{5,798,98,580,108,1003});
    states[798] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-272,799,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[799] = new State(new int[]{108,1001,118,1002,90,-406,10,-406,96,-406,99,-406,31,-406,102,-406,2,-406,98,-406,12,-406,9,-406,97,-406,30,-406,84,-406,83,-406,82,-406,81,-406,80,-406,85,-406},new int[]{-335,800});
    states[800] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,973,133,826,114,362,113,363,61,160,35,678,42,684},new int[]{-84,801,-83,802,-82,257,-87,258,-88,219,-79,803,-13,232,-10,242,-14,205,-143,841,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840,-92,990,-239,991,-320,1000});
    states[801] = new State(-408);
    states[802] = new State(-409);
    states[803] = new State(new int[]{6,804,114,228,113,229,126,230,127,231,118,-118,123,-118,121,-118,119,-118,122,-118,120,-118,135,-118,13,-118,16,-118,90,-118,10,-118,96,-118,99,-118,31,-118,102,-118,2,-118,98,-118,12,-118,9,-118,97,-118,30,-118,84,-118,83,-118,82,-118,81,-118,80,-118,85,-118},new int[]{-189,197});
    states[804] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160},new int[]{-13,805,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834});
    states[805] = new State(new int[]{134,233,136,234,116,235,115,236,129,237,130,238,131,239,132,240,128,241,90,-410,10,-410,96,-410,99,-410,31,-410,102,-410,2,-410,98,-410,12,-410,9,-410,97,-410,30,-410,84,-410,83,-410,82,-410,81,-410,80,-410,85,-410},new int[]{-197,199,-191,202});
    states[806] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559},new int[]{-68,807,-75,346,-89,356,-85,349,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558});
    states[807] = new State(new int[]{75,808});
    states[808] = new State(-165);
    states[809] = new State(-157);
    states[810] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,820,133,826,114,362,113,363,61,160},new int[]{-10,811,-14,812,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,828,-169,830,-57,831});
    states[811] = new State(-158);
    states[812] = new State(new int[]{4,207,11,209,7,813,140,815,8,816,134,-155,136,-155,116,-155,115,-155,129,-155,130,-155,131,-155,132,-155,128,-155,114,-155,113,-155,126,-155,127,-155,118,-155,123,-155,121,-155,119,-155,122,-155,120,-155,135,-155,13,-155,16,-155,6,-155,98,-155,9,-155,12,-155,5,-155,90,-155,10,-155,96,-155,99,-155,31,-155,102,-155,2,-155,97,-155,30,-155,84,-155,83,-155,82,-155,81,-155,80,-155,85,-155},new int[]{-12,206});
    states[813] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,83,56,82,57,81,58,80,59,67,60,62,61,126,62,20,63,19,64,61,65,21,66,127,67,128,68,129,69,130,70,131,71,132,72,133,73,134,74,135,75,136,76,22,77,72,78,89,79,23,80,24,81,27,82,28,83,29,84,70,85,97,86,30,87,90,88,31,89,32,90,25,91,102,92,99,93,33,94,34,95,35,96,38,97,39,98,40,99,101,100,41,101,42,102,44,103,45,104,46,105,95,106,47,107,100,108,48,109,26,110,49,111,69,112,96,113,50,114,51,115,52,116,53,117,54,118,55,119,56,120,57,121,59,122,103,123,104,124,107,125,105,126,106,127,60,128,73,129,36,130,37,131,68,132,145,133,58,134,137,135,138,136,78,137,150,138,149,139,71,140,151,141,147,142,148,143,146,144,43,146},new int[]{-134,814,-143,46,-147,48,-148,51,-289,54,-146,55,-290,145});
    states[814] = new State(-177);
    states[815] = new State(-178);
    states[816] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,652,8,445,19,264,20,269,75,456,38,550,5,559,18,669,35,678,42,684,9,-182},new int[]{-74,817,-70,819,-86,438,-85,27,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558,-319,653,-97,654,-320,677});
    states[817] = new State(new int[]{9,818});
    states[818] = new State(-179);
    states[819] = new State(new int[]{98,373,9,-181});
    states[820] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160},new int[]{-87,821,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840});
    states[821] = new State(new int[]{9,822,13,189,16,193});
    states[822] = new State(-159);
    states[823] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160},new int[]{-87,824,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840});
    states[824] = new State(new int[]{9,825,13,189,16,193});
    states[825] = new State(new int[]{134,-159,136,-159,116,-159,115,-159,129,-159,130,-159,131,-159,132,-159,128,-159,114,-159,113,-159,126,-159,127,-159,118,-159,123,-159,121,-159,119,-159,122,-159,120,-159,135,-159,13,-159,16,-159,6,-159,98,-159,9,-159,12,-159,5,-159,90,-159,10,-159,96,-159,99,-159,31,-159,102,-159,2,-159,97,-159,30,-159,84,-159,83,-159,82,-159,81,-159,80,-159,85,-159,117,-154});
    states[826] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,820,133,826,114,362,113,363,61,160},new int[]{-10,827,-14,812,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,828,-169,830,-57,831});
    states[827] = new State(-160);
    states[828] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,820,133,826,114,362,113,363,61,160},new int[]{-10,829,-14,812,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,828,-169,830,-57,831});
    states[829] = new State(-161);
    states[830] = new State(-162);
    states[831] = new State(-163);
    states[832] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160},new int[]{-10,829,-265,833,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-11,834});
    states[833] = new State(-140);
    states[834] = new State(new int[]{117,835});
    states[835] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160},new int[]{-10,836,-265,837,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-11,834});
    states[836] = new State(-138);
    states[837] = new State(-139);
    states[838] = new State(-142);
    states[839] = new State(-143);
    states[840] = new State(-121);
    states[841] = new State(new int[]{125,842,4,-168,11,-168,7,-168,140,-168,8,-168,134,-168,136,-168,116,-168,115,-168,129,-168,130,-168,131,-168,132,-168,128,-168,6,-168,114,-168,113,-168,126,-168,127,-168,118,-168,123,-168,121,-168,119,-168,122,-168,120,-168,135,-168,13,-168,16,-168,90,-168,10,-168,96,-168,99,-168,31,-168,102,-168,2,-168,98,-168,12,-168,9,-168,97,-168,30,-168,84,-168,83,-168,82,-168,81,-168,80,-168,85,-168,117,-168});
    states[842] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,445,19,264,20,269,75,456,18,669,35,678,42,684,89,17,38,712,52,748,95,743,33,753,34,779,71,850,23,727,100,769,58,858,45,776,73,972},new int[]{-325,843,-101,442,-96,443,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,682,-113,542,-319,683,-97,654,-320,677,-327,844,-251,710,-149,711,-315,845,-243,846,-120,847,-119,848,-121,849,-35,967,-298,968,-165,969,-244,970,-122,971});
    states[843] = new State(-412);
    states[844] = new State(-1001);
    states[845] = new State(-990);
    states[846] = new State(-991);
    states[847] = new State(-992);
    states[848] = new State(-993);
    states[849] = new State(-994);
    states[850] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-98,851,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549});
    states[851] = new State(new int[]{97,852});
    states[852] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,90,-487,10,-487,96,-487,99,-487,31,-487,102,-487,2,-487,98,-487,12,-487,9,-487,97,-487,30,-487,83,-487,82,-487,81,-487,80,-487},new int[]{-256,853,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[853] = new State(-509);
    states[854] = new State(-503);
    states[855] = new State(-588);
    states[856] = new State(-589);
    states[857] = new State(-504);
    states[858] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-98,859,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549});
    states[859] = new State(new int[]{97,860});
    states[860] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,90,-487,10,-487,96,-487,99,-487,31,-487,102,-487,2,-487,98,-487,12,-487,9,-487,97,-487,30,-487,83,-487,82,-487,81,-487,80,-487},new int[]{-256,861,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[861] = new State(-553);
    states[862] = new State(-505);
    states[863] = new State(new int[]{72,865,54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,445,19,264,20,269,75,456,38,550,18,669,35,678,42,684},new int[]{-100,864,-98,867,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-319,868,-97,654,-320,677});
    states[864] = new State(-510);
    states[865] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,445,19,264,20,269,75,456,38,550,18,669,35,678,42,684},new int[]{-100,866,-98,867,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-319,868,-97,654,-320,677});
    states[866] = new State(-511);
    states[867] = new State(-602);
    states[868] = new State(-603);
    states[869] = new State(-506);
    states[870] = new State(-507);
    states[871] = new State(-508);
    states[872] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-98,873,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549});
    states[873] = new State(new int[]{53,874});
    states[874] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,142,150,144,151,143,153,152,155,155,156,154,157,153,158,54,952,19,264,20,269,11,912,8,925},new int[]{-347,875,-346,966,-339,882,-280,887,-176,164,-143,201,-147,48,-148,51,-338,944,-354,947,-336,955,-15,950,-161,147,-163,148,-162,152,-16,154,-253,953,-291,954,-340,956,-341,959});
    states[875] = new State(new int[]{10,878,30,737,90,-547},new int[]{-249,876});
    states[876] = new State(new int[]{90,877});
    states[877] = new State(-529);
    states[878] = new State(new int[]{30,737,141,47,84,49,85,50,79,52,77,53,142,150,144,151,143,153,152,155,155,156,154,157,153,158,54,952,19,264,20,269,11,912,8,925,90,-547},new int[]{-249,879,-346,881,-339,882,-280,887,-176,164,-143,201,-147,48,-148,51,-338,944,-354,947,-336,955,-15,950,-161,147,-163,148,-162,152,-16,154,-253,953,-291,954,-340,956,-341,959});
    states[879] = new State(new int[]{90,880});
    states[880] = new State(-530);
    states[881] = new State(-532);
    states[882] = new State(new int[]{37,883});
    states[883] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-98,884,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549});
    states[884] = new State(new int[]{5,885});
    states[885] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,10,-487,30,-487,90,-487},new int[]{-256,886,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[886] = new State(-533);
    states[887] = new State(new int[]{8,888,98,-641,5,-641});
    states[888] = new State(new int[]{14,893,142,150,144,151,143,153,152,155,155,156,154,157,153,158,114,362,113,363,141,47,84,49,85,50,79,52,77,53,51,900,11,912,8,925},new int[]{-351,889,-349,943,-15,894,-161,147,-163,148,-162,152,-16,154,-195,895,-143,897,-147,48,-148,51,-339,904,-280,905,-176,164,-340,911,-341,942});
    states[889] = new State(new int[]{9,890,10,891,98,909});
    states[890] = new State(new int[]{37,-635,5,-636});
    states[891] = new State(new int[]{14,893,142,150,144,151,143,153,152,155,155,156,154,157,153,158,114,362,113,363,141,47,84,49,85,50,79,52,77,53,51,900,11,912,8,925},new int[]{-349,892,-15,894,-161,147,-163,148,-162,152,-16,154,-195,895,-143,897,-147,48,-148,51,-339,904,-280,905,-176,164,-340,911,-341,942});
    states[892] = new State(-667);
    states[893] = new State(-679);
    states[894] = new State(-680);
    states[895] = new State(new int[]{142,150,144,151,143,153,152,155,155,156,154,157,153,158},new int[]{-15,896,-161,147,-163,148,-162,152,-16,154});
    states[896] = new State(-681);
    states[897] = new State(new int[]{5,898,9,-683,10,-683,98,-683,7,-259,4,-259,121,-259,8,-259});
    states[898] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-272,899,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[899] = new State(-682);
    states[900] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-143,901,-147,48,-148,51});
    states[901] = new State(new int[]{5,902,9,-685,10,-685,98,-685});
    states[902] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-272,903,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[903] = new State(-684);
    states[904] = new State(-686);
    states[905] = new State(new int[]{8,906});
    states[906] = new State(new int[]{14,893,142,150,144,151,143,153,152,155,155,156,154,157,153,158,114,362,113,363,141,47,84,49,85,50,79,52,77,53,51,900,11,912,8,925},new int[]{-351,907,-349,943,-15,894,-161,147,-163,148,-162,152,-16,154,-195,895,-143,897,-147,48,-148,51,-339,904,-280,905,-176,164,-340,911,-341,942});
    states[907] = new State(new int[]{9,908,10,891,98,909});
    states[908] = new State(-635);
    states[909] = new State(new int[]{14,893,142,150,144,151,143,153,152,155,155,156,154,157,153,158,114,362,113,363,141,47,84,49,85,50,79,52,77,53,51,900,11,912,8,925},new int[]{-349,910,-15,894,-161,147,-163,148,-162,152,-16,154,-195,895,-143,897,-147,48,-148,51,-339,904,-280,905,-176,164,-340,911,-341,942});
    states[910] = new State(-668);
    states[911] = new State(-687);
    states[912] = new State(new int[]{142,150,144,151,143,153,152,155,155,156,154,157,153,158,51,919,14,921,141,47,84,49,85,50,79,52,77,53,11,912,8,925,6,940},new int[]{-352,913,-342,941,-15,917,-161,147,-163,148,-162,152,-16,154,-344,918,-339,922,-280,905,-176,164,-143,201,-147,48,-148,51,-340,923,-341,924});
    states[913] = new State(new int[]{12,914,98,915});
    states[914] = new State(-645);
    states[915] = new State(new int[]{142,150,144,151,143,153,152,155,155,156,154,157,153,158,51,919,14,921,141,47,84,49,85,50,79,52,77,53,11,912,8,925,6,940},new int[]{-342,916,-15,917,-161,147,-163,148,-162,152,-16,154,-344,918,-339,922,-280,905,-176,164,-143,201,-147,48,-148,51,-340,923,-341,924});
    states[916] = new State(-647);
    states[917] = new State(-648);
    states[918] = new State(-649);
    states[919] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-143,920,-147,48,-148,51});
    states[920] = new State(-655);
    states[921] = new State(-650);
    states[922] = new State(-651);
    states[923] = new State(-652);
    states[924] = new State(-653);
    states[925] = new State(new int[]{14,930,142,150,144,151,143,153,152,155,155,156,154,157,153,158,114,362,113,363,51,934,141,47,84,49,85,50,79,52,77,53,11,912,8,925},new int[]{-353,926,-343,939,-15,931,-161,147,-163,148,-162,152,-16,154,-195,932,-339,936,-280,905,-176,164,-143,201,-147,48,-148,51,-340,937,-341,938});
    states[926] = new State(new int[]{9,927,98,928});
    states[927] = new State(-656);
    states[928] = new State(new int[]{14,930,142,150,144,151,143,153,152,155,155,156,154,157,153,158,114,362,113,363,51,934,141,47,84,49,85,50,79,52,77,53,11,912,8,925},new int[]{-343,929,-15,931,-161,147,-163,148,-162,152,-16,154,-195,932,-339,936,-280,905,-176,164,-143,201,-147,48,-148,51,-340,937,-341,938});
    states[929] = new State(-665);
    states[930] = new State(-657);
    states[931] = new State(-658);
    states[932] = new State(new int[]{142,150,144,151,143,153,152,155,155,156,154,157,153,158},new int[]{-15,933,-161,147,-163,148,-162,152,-16,154});
    states[933] = new State(-659);
    states[934] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-143,935,-147,48,-148,51});
    states[935] = new State(-660);
    states[936] = new State(-661);
    states[937] = new State(-662);
    states[938] = new State(-663);
    states[939] = new State(-664);
    states[940] = new State(-654);
    states[941] = new State(-646);
    states[942] = new State(-688);
    states[943] = new State(-666);
    states[944] = new State(new int[]{5,945});
    states[945] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,10,-487,30,-487,90,-487},new int[]{-256,946,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[946] = new State(-534);
    states[947] = new State(new int[]{98,948,5,-637});
    states[948] = new State(new int[]{142,150,144,151,143,153,152,155,155,156,154,157,153,158,141,47,84,49,85,50,79,52,77,53,54,952,19,264,20,269},new int[]{-336,949,-15,950,-161,147,-163,148,-162,152,-16,154,-280,951,-176,164,-143,201,-147,48,-148,51,-253,953,-291,954});
    states[949] = new State(-639);
    states[950] = new State(-640);
    states[951] = new State(-641);
    states[952] = new State(-642);
    states[953] = new State(-643);
    states[954] = new State(-644);
    states[955] = new State(-638);
    states[956] = new State(new int[]{5,957});
    states[957] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,10,-487,30,-487,90,-487},new int[]{-256,958,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[958] = new State(-535);
    states[959] = new State(new int[]{37,960,5,964});
    states[960] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-98,961,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549});
    states[961] = new State(new int[]{5,962});
    states[962] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,10,-487,30,-487,90,-487},new int[]{-256,963,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[963] = new State(-536);
    states[964] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,10,-487,30,-487,90,-487},new int[]{-256,965,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[965] = new State(-537);
    states[966] = new State(-531);
    states[967] = new State(-995);
    states[968] = new State(-996);
    states[969] = new State(-997);
    states[970] = new State(-998);
    states[971] = new State(-999);
    states[972] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,445,19,264,20,269,75,456,38,550,18,669,35,678,42,684},new int[]{-100,864,-98,867,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-319,868,-97,654,-320,677});
    states[973] = new State(new int[]{9,981,141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,986,133,826,114,362,113,363,61,160},new int[]{-87,974,-66,975,-241,979,-88,219,-79,227,-13,232,-10,242,-14,205,-143,985,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840,-65,254,-83,989,-82,257,-92,990,-239,991,-240,992,-242,999,-132,995});
    states[974] = new State(new int[]{9,825,13,189,16,193,98,-193});
    states[975] = new State(new int[]{9,976});
    states[976] = new State(new int[]{125,977,90,-196,10,-196,96,-196,99,-196,31,-196,102,-196,2,-196,98,-196,12,-196,9,-196,97,-196,30,-196,84,-196,83,-196,82,-196,81,-196,80,-196,85,-196});
    states[977] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,445,19,264,20,269,75,456,18,669,35,678,42,684,89,17,38,712,52,748,95,743,33,753,34,779,71,850,23,727,100,769,58,858,45,776,73,972},new int[]{-325,978,-101,442,-96,443,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,682,-113,542,-319,683,-97,654,-320,677,-327,844,-251,710,-149,711,-315,845,-243,846,-120,847,-119,848,-121,849,-35,967,-298,968,-165,969,-244,970,-122,971});
    states[978] = new State(-414);
    states[979] = new State(new int[]{9,980});
    states[980] = new State(-201);
    states[981] = new State(new int[]{5,582,125,-984},new int[]{-321,982});
    states[982] = new State(new int[]{125,983});
    states[983] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,445,19,264,20,269,75,456,18,669,35,678,42,684,89,17,38,712,52,748,95,743,33,753,34,779,71,850,23,727,100,769,58,858,45,776,73,972},new int[]{-325,984,-101,442,-96,443,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,682,-113,542,-319,683,-97,654,-320,677,-327,844,-251,710,-149,711,-315,845,-243,846,-120,847,-119,848,-121,849,-35,967,-298,968,-165,969,-244,970,-122,971});
    states[984] = new State(-413);
    states[985] = new State(new int[]{4,-168,11,-168,7,-168,140,-168,8,-168,134,-168,136,-168,116,-168,115,-168,129,-168,130,-168,131,-168,132,-168,128,-168,114,-168,113,-168,126,-168,127,-168,118,-168,123,-168,121,-168,119,-168,122,-168,120,-168,135,-168,9,-168,13,-168,16,-168,98,-168,117,-168,5,-207});
    states[986] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,986,133,826,114,362,113,363,61,160,9,-197},new int[]{-87,974,-66,987,-241,979,-88,219,-79,227,-13,232,-10,242,-14,205,-143,985,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840,-65,254,-83,989,-82,257,-92,990,-239,991,-240,992,-242,999,-132,995});
    states[987] = new State(new int[]{9,988});
    states[988] = new State(-196);
    states[989] = new State(-199);
    states[990] = new State(-194);
    states[991] = new State(-195);
    states[992] = new State(new int[]{10,993,9,-202});
    states[993] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,9,-203},new int[]{-242,994,-132,995,-143,998,-147,48,-148,51});
    states[994] = new State(-205);
    states[995] = new State(new int[]{5,996});
    states[996] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,986,133,826,114,362,113,363,61,160},new int[]{-82,997,-87,258,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840,-92,990,-239,991});
    states[997] = new State(-206);
    states[998] = new State(-207);
    states[999] = new State(-204);
    states[1000] = new State(-411);
    states[1001] = new State(-404);
    states[1002] = new State(-405);
    states[1003] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,652,8,445,19,264,20,269,75,456,38,550,5,559,18,669,35,678,42,684},new int[]{-86,1004,-85,27,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558,-319,653,-97,654,-320,677});
    states[1004] = new State(-407);
    states[1005] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-272,1006,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[1006] = new State(-558);
    states[1007] = new State(new int[]{8,1019,141,47,84,49,85,50,79,52,77,53},new int[]{-143,1008,-147,48,-148,51});
    states[1008] = new State(new int[]{5,1009,135,1015});
    states[1009] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-272,1010,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[1010] = new State(new int[]{135,1011});
    states[1011] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-98,1012,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549});
    states[1012] = new State(new int[]{97,1013});
    states[1013] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,90,-487,10,-487,96,-487,99,-487,31,-487,102,-487,2,-487,98,-487,12,-487,9,-487,97,-487,30,-487,83,-487,82,-487,81,-487,80,-487},new int[]{-256,1014,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[1014] = new State(-555);
    states[1015] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-98,1016,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549});
    states[1016] = new State(new int[]{97,1017});
    states[1017] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,90,-487,10,-487,96,-487,99,-487,31,-487,102,-487,2,-487,98,-487,12,-487,9,-487,97,-487,30,-487,83,-487,82,-487,81,-487,80,-487},new int[]{-256,1018,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[1018] = new State(-556);
    states[1019] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-154,1020,-143,796,-147,48,-148,51});
    states[1020] = new State(new int[]{9,1021,98,580});
    states[1021] = new State(new int[]{135,1022});
    states[1022] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-98,1023,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549});
    states[1023] = new State(new int[]{97,1024});
    states[1024] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,90,-487,10,-487,96,-487,99,-487,31,-487,102,-487,2,-487,98,-487,12,-487,9,-487,97,-487,30,-487,83,-487,82,-487,81,-487,80,-487},new int[]{-256,1025,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[1025] = new State(-557);
    states[1026] = new State(new int[]{5,1027});
    states[1027] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,741,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,90,-487,10,-487,96,-487,99,-487,31,-487,102,-487,2,-487},new int[]{-257,1028,-256,22,-4,23,-109,24,-128,367,-108,534,-143,740,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871,-139,1026});
    states[1028] = new State(-486);
    states[1029] = new State(new int[]{78,1037,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,741,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,10,-487,90,-487},new int[]{-60,1030,-63,1032,-62,1049,-248,1050,-257,739,-256,22,-4,23,-109,24,-128,367,-108,534,-143,740,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871,-139,1026});
    states[1030] = new State(new int[]{90,1031});
    states[1031] = new State(-571);
    states[1032] = new State(new int[]{10,1034,30,1047,90,-577},new int[]{-250,1033});
    states[1033] = new State(-572);
    states[1034] = new State(new int[]{78,1037,30,1047,90,-577},new int[]{-62,1035,-250,1036});
    states[1035] = new State(-576);
    states[1036] = new State(-573);
    states[1037] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-64,1038,-175,1041,-176,1042,-143,1043,-147,48,-148,51,-136,1044});
    states[1038] = new State(new int[]{97,1039});
    states[1039] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,10,-487,30,-487,90,-487},new int[]{-256,1040,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[1040] = new State(-579);
    states[1041] = new State(-580);
    states[1042] = new State(new int[]{7,165,97,-582});
    states[1043] = new State(new int[]{7,-259,97,-259,5,-583});
    states[1044] = new State(new int[]{5,1045});
    states[1045] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-175,1046,-176,1042,-143,201,-147,48,-148,51});
    states[1046] = new State(-581);
    states[1047] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,741,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,10,-487,90,-487},new int[]{-248,1048,-257,739,-256,22,-4,23,-109,24,-128,367,-108,534,-143,740,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871,-139,1026});
    states[1048] = new State(new int[]{10,20,90,-578});
    states[1049] = new State(-575);
    states[1050] = new State(new int[]{10,20,90,-574});
    states[1051] = new State(-551);
    states[1052] = new State(-565);
    states[1053] = new State(-566);
    states[1054] = new State(-563);
    states[1055] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-176,1056,-143,201,-147,48,-148,51});
    states[1056] = new State(new int[]{108,1057,7,165});
    states[1057] = new State(-564);
    states[1058] = new State(-561);
    states[1059] = new State(new int[]{5,1060,98,1062});
    states[1060] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,10,-487,30,-487,90,-487},new int[]{-256,1061,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[1061] = new State(-543);
    states[1062] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160},new int[]{-107,1063,-91,1064,-87,188,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840});
    states[1063] = new State(-545);
    states[1064] = new State(-546);
    states[1065] = new State(-544);
    states[1066] = new State(new int[]{90,1067});
    states[1067] = new State(-540);
    states[1068] = new State(-541);
    states[1069] = new State(new int[]{9,1070,141,47,84,49,85,50,79,52,77,53},new int[]{-323,1073,-324,1077,-154,578,-143,796,-147,48,-148,51});
    states[1070] = new State(new int[]{125,1071});
    states[1071] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,53,43,385,40,423,8,688,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,89,17,38,712,52,748,95,743,33,753,34,779,71,850,23,727,100,769,58,858,45,776,73,972},new int[]{-326,1072,-208,687,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-4,708,-327,709,-251,710,-149,711,-315,845,-243,846,-120,847,-119,848,-121,849,-35,967,-298,968,-165,969,-244,970,-122,971});
    states[1072] = new State(-979);
    states[1073] = new State(new int[]{9,1074,10,576});
    states[1074] = new State(new int[]{125,1075});
    states[1075] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,53,43,385,40,423,8,688,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,89,17,38,712,52,748,95,743,33,753,34,779,71,850,23,727,100,769,58,858,45,776,73,972},new int[]{-326,1076,-208,687,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-4,708,-327,709,-251,710,-149,711,-315,845,-243,846,-120,847,-119,848,-121,849,-35,967,-298,968,-165,969,-244,970,-122,971});
    states[1076] = new State(-980);
    states[1077] = new State(-981);
    states[1078] = new State(new int[]{9,1079,141,47,84,49,85,50,79,52,77,53},new int[]{-323,1083,-324,1077,-154,578,-143,796,-147,48,-148,51});
    states[1079] = new State(new int[]{5,656,125,-986},new int[]{-322,1080});
    states[1080] = new State(new int[]{125,1081});
    states[1081] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,445,19,264,20,269,75,456,18,669,35,678,42,684,89,17,38,712,52,748,95,743,33,753,34,779,71,850,23,727,100,769,58,858,45,776,73,972},new int[]{-325,1082,-101,442,-96,443,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,682,-113,542,-319,683,-97,654,-320,677,-327,844,-251,710,-149,711,-315,845,-243,846,-120,847,-119,848,-121,849,-35,967,-298,968,-165,969,-244,970,-122,971});
    states[1082] = new State(-976);
    states[1083] = new State(new int[]{9,1084,10,576});
    states[1084] = new State(new int[]{5,656,125,-986},new int[]{-322,1085});
    states[1085] = new State(new int[]{125,1086});
    states[1086] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,445,19,264,20,269,75,456,18,669,35,678,42,684,89,17,38,712,52,748,95,743,33,753,34,779,71,850,23,727,100,769,58,858,45,776,73,972},new int[]{-325,1087,-101,442,-96,443,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,682,-113,542,-319,683,-97,654,-320,677,-327,844,-251,710,-149,711,-315,845,-243,846,-120,847,-119,848,-121,849,-35,967,-298,968,-165,969,-244,970,-122,971});
    states[1087] = new State(-977);
    states[1088] = new State(new int[]{5,1089,7,-259,8,-259,121,-259,12,-259,98,-259});
    states[1089] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-9,1090,-176,646,-143,201,-147,48,-148,51,-297,1091});
    states[1090] = new State(-216);
    states[1091] = new State(new int[]{8,649,12,-628,98,-628},new int[]{-69,1092});
    states[1092] = new State(-766);
    states[1093] = new State(-213);
    states[1094] = new State(-209);
    states[1095] = new State(-466);
    states[1096] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,18,669},new int[]{-99,1097,-98,1098,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-97,707});
    states[1097] = new State(-963);
    states[1098] = new State(-960);
    states[1099] = new State(-962);
    states[1100] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-143,1101,-147,48,-148,51});
    states[1101] = new State(new int[]{98,1102,108,704});
    states[1102] = new State(new int[]{51,1110},new int[]{-334,1103});
    states[1103] = new State(new int[]{9,1104,98,1107});
    states[1104] = new State(new int[]{108,1105});
    states[1105] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559},new int[]{-85,1106,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558});
    states[1106] = new State(-513);
    states[1107] = new State(new int[]{51,1108});
    states[1108] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-143,1109,-147,48,-148,51});
    states[1109] = new State(-521);
    states[1110] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-143,1111,-147,48,-148,51});
    states[1111] = new State(-520);
    states[1112] = new State(new int[]{145,1116,147,1117,148,1118,149,1119,151,1120,150,1121,105,-807,89,-807,57,-807,27,-807,65,-807,48,-807,51,-807,60,-807,11,-807,26,-807,24,-807,42,-807,35,-807,28,-807,29,-807,44,-807,25,-807,90,-807,83,-807,82,-807,81,-807,80,-807,21,-807,146,-807,39,-807},new int[]{-202,1113,-205,1122});
    states[1113] = new State(new int[]{10,1114});
    states[1114] = new State(new int[]{145,1116,147,1117,148,1118,149,1119,151,1120,150,1121,105,-808,89,-808,57,-808,27,-808,65,-808,48,-808,51,-808,60,-808,11,-808,26,-808,24,-808,42,-808,35,-808,28,-808,29,-808,44,-808,25,-808,90,-808,83,-808,82,-808,81,-808,80,-808,21,-808,146,-808,39,-808},new int[]{-205,1115});
    states[1115] = new State(-812);
    states[1116] = new State(-822);
    states[1117] = new State(-823);
    states[1118] = new State(-824);
    states[1119] = new State(-825);
    states[1120] = new State(-826);
    states[1121] = new State(-827);
    states[1122] = new State(-811);
    states[1123] = new State(-375);
    states[1124] = new State(-440);
    states[1125] = new State(-441);
    states[1126] = new State(new int[]{8,-446,108,-446,10,-446,11,-446,5,-446,7,-443});
    states[1127] = new State(new int[]{121,1129,8,-449,108,-449,10,-449,7,-449,11,-449,5,-449},new int[]{-151,1128});
    states[1128] = new State(-450);
    states[1129] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-154,1130,-143,796,-147,48,-148,51});
    states[1130] = new State(new int[]{119,1131,98,580});
    states[1131] = new State(-322);
    states[1132] = new State(-451);
    states[1133] = new State(new int[]{121,1129,8,-447,108,-447,10,-447,11,-447,5,-447},new int[]{-151,1134});
    states[1134] = new State(-448);
    states[1135] = new State(new int[]{7,1136});
    states[1136] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,43,385},new int[]{-138,1137,-145,1138,-133,1126,-130,1127,-143,1132,-147,48,-148,51,-187,1133});
    states[1137] = new State(-442);
    states[1138] = new State(-445);
    states[1139] = new State(-444);
    states[1140] = new State(-433);
    states[1141] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,43,385},new int[]{-166,1142,-138,1125,-133,1126,-130,1127,-143,1132,-147,48,-148,51,-187,1133,-331,1135,-145,1139});
    states[1142] = new State(new int[]{11,1170,5,-389},new int[]{-229,1143,-234,1167});
    states[1143] = new State(new int[]{84,1156,85,1162,10,-396},new int[]{-198,1144});
    states[1144] = new State(new int[]{10,1145});
    states[1145] = new State(new int[]{61,1150,150,1152,149,1153,145,1154,148,1155,11,-386,26,-386,24,-386,42,-386,35,-386,28,-386,29,-386,44,-386,25,-386,90,-386,83,-386,82,-386,81,-386,80,-386},new int[]{-201,1146,-206,1147});
    states[1146] = new State(-380);
    states[1147] = new State(new int[]{10,1148});
    states[1148] = new State(new int[]{61,1150,11,-386,26,-386,24,-386,42,-386,35,-386,28,-386,29,-386,44,-386,25,-386,90,-386,83,-386,82,-386,81,-386,80,-386},new int[]{-201,1149});
    states[1149] = new State(-381);
    states[1150] = new State(new int[]{10,1151});
    states[1151] = new State(-387);
    states[1152] = new State(-828);
    states[1153] = new State(-829);
    states[1154] = new State(-830);
    states[1155] = new State(-831);
    states[1156] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,652,8,445,19,264,20,269,75,456,38,550,5,559,18,669,35,678,42,684,10,-395},new int[]{-110,1157,-86,1161,-85,27,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558,-319,653,-97,654,-320,677});
    states[1157] = new State(new int[]{85,1159,10,-399},new int[]{-199,1158});
    states[1158] = new State(-397);
    states[1159] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,10,-487},new int[]{-256,1160,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[1160] = new State(-400);
    states[1161] = new State(-394);
    states[1162] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,10,-487},new int[]{-256,1163,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[1163] = new State(new int[]{84,1165,10,-401},new int[]{-200,1164});
    states[1164] = new State(-398);
    states[1165] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,652,8,445,19,264,20,269,75,456,38,550,5,559,18,669,35,678,42,684,10,-395},new int[]{-110,1166,-86,1161,-85,27,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558,-319,653,-97,654,-320,677});
    states[1166] = new State(-402);
    states[1167] = new State(new int[]{5,1168});
    states[1168] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-271,1169,-272,500,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[1169] = new State(-388);
    states[1170] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-233,1171,-232,1178,-154,1175,-143,796,-147,48,-148,51});
    states[1171] = new State(new int[]{12,1172,10,1173});
    states[1172] = new State(-390);
    states[1173] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-232,1174,-154,1175,-143,796,-147,48,-148,51});
    states[1174] = new State(-392);
    states[1175] = new State(new int[]{5,1176,98,580});
    states[1176] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-271,1177,-272,500,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[1177] = new State(-393);
    states[1178] = new State(-391);
    states[1179] = new State(new int[]{44,1180});
    states[1180] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,43,385},new int[]{-166,1181,-138,1125,-133,1126,-130,1127,-143,1132,-147,48,-148,51,-187,1133,-331,1135,-145,1139});
    states[1181] = new State(new int[]{11,1170,5,-389},new int[]{-229,1182,-234,1167});
    states[1182] = new State(new int[]{108,1185,10,-385},new int[]{-207,1183});
    states[1183] = new State(new int[]{10,1184});
    states[1184] = new State(-383);
    states[1185] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559},new int[]{-85,1186,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558});
    states[1186] = new State(-384);
    states[1187] = new State(new int[]{105,1316,11,-369,26,-369,24,-369,42,-369,35,-369,28,-369,29,-369,44,-369,25,-369,90,-369,83,-369,82,-369,81,-369,80,-369,57,-70,27,-70,65,-70,48,-70,51,-70,60,-70,89,-70},new int[]{-172,1188,-43,1189,-39,1192,-61,1315});
    states[1188] = new State(-434);
    states[1189] = new State(new int[]{89,17},new int[]{-251,1190});
    states[1190] = new State(new int[]{10,1191});
    states[1191] = new State(-461);
    states[1192] = new State(new int[]{57,1195,27,1216,65,1220,48,1379,51,1394,60,1396,89,-69},new int[]{-46,1193,-164,1194,-29,1201,-52,1218,-285,1222,-306,1381});
    states[1193] = new State(-71);
    states[1194] = new State(-87);
    states[1195] = new State(new int[]{152,722,141,47,84,49,85,50,79,52,77,53},new int[]{-152,1196,-139,1200,-143,723,-147,48,-148,51});
    states[1196] = new State(new int[]{10,1197,98,1198});
    states[1197] = new State(-96);
    states[1198] = new State(new int[]{152,722,141,47,84,49,85,50,79,52,77,53},new int[]{-139,1199,-143,723,-147,48,-148,51});
    states[1199] = new State(-98);
    states[1200] = new State(-97);
    states[1201] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,57,-88,27,-88,65,-88,48,-88,51,-88,60,-88,89,-88},new int[]{-27,1202,-28,1203,-137,1205,-143,1215,-147,48,-148,51});
    states[1202] = new State(-102);
    states[1203] = new State(new int[]{10,1204});
    states[1204] = new State(-112);
    states[1205] = new State(new int[]{118,1206,5,1211});
    states[1206] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,1209,133,826,114,362,113,363,61,160},new int[]{-106,1207,-87,1208,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840,-92,1210});
    states[1207] = new State(-113);
    states[1208] = new State(new int[]{13,189,16,193,10,-115,90,-115,83,-115,82,-115,81,-115,80,-115});
    states[1209] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,986,133,826,114,362,113,363,61,160,9,-197},new int[]{-87,974,-66,987,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840,-65,254,-83,989,-82,257,-92,990,-239,991});
    states[1210] = new State(-116);
    states[1211] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-272,1212,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[1212] = new State(new int[]{118,1213});
    states[1213] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,986,133,826,114,362,113,363,61,160},new int[]{-82,1214,-87,258,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840,-92,990,-239,991});
    states[1214] = new State(-114);
    states[1215] = new State(-117);
    states[1216] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-27,1217,-28,1203,-137,1205,-143,1215,-147,48,-148,51});
    states[1217] = new State(-101);
    states[1218] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,57,-89,27,-89,65,-89,48,-89,51,-89,60,-89,89,-89},new int[]{-27,1219,-28,1203,-137,1205,-143,1215,-147,48,-148,51});
    states[1219] = new State(-104);
    states[1220] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-27,1221,-28,1203,-137,1205,-143,1215,-147,48,-148,51});
    states[1221] = new State(-103);
    states[1222] = new State(new int[]{11,640,57,-90,27,-90,65,-90,48,-90,51,-90,60,-90,89,-90,141,-211,84,-211,85,-211,79,-211,77,-211},new int[]{-49,1223,-6,1224,-246,1094});
    states[1223] = new State(-106);
    states[1224] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,11,640},new int[]{-50,1225,-246,522,-140,1226,-143,1371,-147,48,-148,51,-141,1376});
    states[1225] = new State(-208);
    states[1226] = new State(new int[]{118,1227});
    states[1227] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616,67,1365,68,1366,145,1367,25,1368,26,1369,24,-304,41,-304,62,-304},new int[]{-283,1228,-272,1230,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600,-30,1231,-21,1232,-22,1363,-20,1370});
    states[1228] = new State(new int[]{10,1229});
    states[1229] = new State(-217);
    states[1230] = new State(-222);
    states[1231] = new State(-223);
    states[1232] = new State(new int[]{24,1357,41,1358,62,1359},new int[]{-287,1233});
    states[1233] = new State(new int[]{8,1274,21,-316,11,-316,90,-316,83,-316,82,-316,81,-316,80,-316,27,-316,141,-316,84,-316,85,-316,79,-316,77,-316,60,-316,26,-316,24,-316,42,-316,35,-316,28,-316,29,-316,44,-316,25,-316,10,-316},new int[]{-179,1234});
    states[1234] = new State(new int[]{21,1265,11,-323,90,-323,83,-323,82,-323,81,-323,80,-323,27,-323,141,-323,84,-323,85,-323,79,-323,77,-323,60,-323,26,-323,24,-323,42,-323,35,-323,28,-323,29,-323,44,-323,25,-323,10,-323},new int[]{-314,1235,-313,1263,-312,1285});
    states[1235] = new State(new int[]{11,640,10,-314,90,-340,83,-340,82,-340,81,-340,80,-340,27,-211,141,-211,84,-211,85,-211,79,-211,77,-211,60,-211,26,-211,24,-211,42,-211,35,-211,28,-211,29,-211,44,-211,25,-211},new int[]{-26,1236,-25,1237,-32,1243,-34,513,-45,1244,-6,1245,-246,1094,-33,1354,-54,1356,-53,519,-55,1355});
    states[1236] = new State(-297);
    states[1237] = new State(new int[]{90,1238,83,1239,82,1240,81,1241,80,1242},new int[]{-7,511});
    states[1238] = new State(-315);
    states[1239] = new State(-336);
    states[1240] = new State(-337);
    states[1241] = new State(-338);
    states[1242] = new State(-339);
    states[1243] = new State(-334);
    states[1244] = new State(-348);
    states[1245] = new State(new int[]{27,1247,141,47,84,49,85,50,79,52,77,53,60,1251,26,1310,24,1311,11,640,42,1258,35,1293,28,1325,29,1332,44,1339,25,1348},new int[]{-51,1246,-246,522,-218,521,-215,523,-254,524,-309,1249,-308,1250,-154,797,-143,796,-147,48,-148,51,-3,1255,-226,1312,-224,1187,-221,1257,-225,1292,-223,1313,-211,1336,-212,1337,-214,1338});
    states[1246] = new State(-350);
    states[1247] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-28,1248,-137,1205,-143,1215,-147,48,-148,51});
    states[1248] = new State(-355);
    states[1249] = new State(-356);
    states[1250] = new State(-360);
    states[1251] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-154,1252,-143,796,-147,48,-148,51});
    states[1252] = new State(new int[]{5,1253,98,580});
    states[1253] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-272,1254,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[1254] = new State(-361);
    states[1255] = new State(new int[]{28,527,44,1141,25,1179,141,47,84,49,85,50,79,52,77,53,60,1251,42,1258,35,1293},new int[]{-309,1256,-226,526,-212,1140,-308,1250,-154,797,-143,796,-147,48,-148,51,-224,1187,-221,1257,-225,1292});
    states[1256] = new State(-357);
    states[1257] = new State(-370);
    states[1258] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,43,385},new int[]{-167,1259,-166,1124,-138,1125,-133,1126,-130,1127,-143,1132,-147,48,-148,51,-187,1133,-331,1135,-145,1139});
    states[1259] = new State(new int[]{8,603,10,-463,108,-463},new int[]{-124,1260});
    states[1260] = new State(new int[]{10,1290,108,-809},new int[]{-203,1261,-204,1286});
    states[1261] = new State(new int[]{21,1265,105,-323,89,-323,57,-323,27,-323,65,-323,48,-323,51,-323,60,-323,11,-323,26,-323,24,-323,42,-323,35,-323,28,-323,29,-323,44,-323,25,-323,90,-323,83,-323,82,-323,81,-323,80,-323,146,-323,39,-323},new int[]{-314,1262,-313,1263,-312,1285});
    states[1262] = new State(-452);
    states[1263] = new State(new int[]{21,1265,11,-324,90,-324,83,-324,82,-324,81,-324,80,-324,27,-324,141,-324,84,-324,85,-324,79,-324,77,-324,60,-324,26,-324,24,-324,42,-324,35,-324,28,-324,29,-324,44,-324,25,-324,10,-324,105,-324,89,-324,57,-324,65,-324,48,-324,51,-324,146,-324,39,-324},new int[]{-312,1264});
    states[1264] = new State(-326);
    states[1265] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-154,1266,-143,796,-147,48,-148,51});
    states[1266] = new State(new int[]{5,1267,98,580});
    states[1267] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,1273,47,585,32,589,72,593,63,596,42,601,35,616,24,1282,28,1283},new int[]{-284,1268,-281,1284,-272,1272,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[1268] = new State(new int[]{10,1269,98,1270});
    states[1269] = new State(-327);
    states[1270] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,1273,47,585,32,589,72,593,63,596,42,601,35,616,24,1282,28,1283},new int[]{-281,1271,-272,1272,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[1271] = new State(-329);
    states[1272] = new State(-330);
    states[1273] = new State(new int[]{8,1274,10,-332,98,-332,21,-316,11,-316,90,-316,83,-316,82,-316,81,-316,80,-316,27,-316,141,-316,84,-316,85,-316,79,-316,77,-316,60,-316,26,-316,24,-316,42,-316,35,-316,28,-316,29,-316,44,-316,25,-316},new int[]{-179,507});
    states[1274] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-178,1275,-177,1281,-176,1279,-143,201,-147,48,-148,51,-297,1280});
    states[1275] = new State(new int[]{9,1276,98,1277});
    states[1276] = new State(-317);
    states[1277] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-177,1278,-176,1279,-143,201,-147,48,-148,51,-297,1280});
    states[1278] = new State(-319);
    states[1279] = new State(new int[]{7,165,121,170,9,-320,98,-320},new int[]{-295,648});
    states[1280] = new State(-321);
    states[1281] = new State(-318);
    states[1282] = new State(-331);
    states[1283] = new State(-333);
    states[1284] = new State(-328);
    states[1285] = new State(-325);
    states[1286] = new State(new int[]{108,1287});
    states[1287] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,10,-487},new int[]{-256,1288,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[1288] = new State(new int[]{10,1289});
    states[1289] = new State(-437);
    states[1290] = new State(new int[]{145,1116,147,1117,148,1118,149,1119,151,1120,150,1121,21,-807,105,-807,89,-807,57,-807,27,-807,65,-807,48,-807,51,-807,60,-807,11,-807,26,-807,24,-807,42,-807,35,-807,28,-807,29,-807,44,-807,25,-807,90,-807,83,-807,82,-807,81,-807,80,-807,146,-807},new int[]{-202,1291,-205,1122});
    states[1291] = new State(new int[]{10,1114,108,-810});
    states[1292] = new State(-371);
    states[1293] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,43,385},new int[]{-166,1294,-138,1125,-133,1126,-130,1127,-143,1132,-147,48,-148,51,-187,1133,-331,1135,-145,1139});
    states[1294] = new State(new int[]{8,603,5,-463,10,-463,108,-463},new int[]{-124,1295});
    states[1295] = new State(new int[]{5,1298,10,1290,108,-809},new int[]{-203,1296,-204,1306});
    states[1296] = new State(new int[]{21,1265,105,-323,89,-323,57,-323,27,-323,65,-323,48,-323,51,-323,60,-323,11,-323,26,-323,24,-323,42,-323,35,-323,28,-323,29,-323,44,-323,25,-323,90,-323,83,-323,82,-323,81,-323,80,-323,146,-323,39,-323},new int[]{-314,1297,-313,1263,-312,1285});
    states[1297] = new State(-453);
    states[1298] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-271,1299,-272,500,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[1299] = new State(new int[]{10,1290,108,-809},new int[]{-203,1300,-204,1302});
    states[1300] = new State(new int[]{21,1265,105,-323,89,-323,57,-323,27,-323,65,-323,48,-323,51,-323,60,-323,11,-323,26,-323,24,-323,42,-323,35,-323,28,-323,29,-323,44,-323,25,-323,90,-323,83,-323,82,-323,81,-323,80,-323,146,-323,39,-323},new int[]{-314,1301,-313,1263,-312,1285});
    states[1301] = new State(-454);
    states[1302] = new State(new int[]{108,1303});
    states[1303] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,445,19,264,20,269,75,456,38,550,18,669,35,678,42,684},new int[]{-100,1304,-98,867,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-319,868,-97,654,-320,677});
    states[1304] = new State(new int[]{10,1305});
    states[1305] = new State(-435);
    states[1306] = new State(new int[]{108,1307});
    states[1307] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,445,19,264,20,269,75,456,38,550,18,669,35,678,42,684},new int[]{-100,1308,-98,867,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-319,868,-97,654,-320,677});
    states[1308] = new State(new int[]{10,1309});
    states[1309] = new State(-436);
    states[1310] = new State(-358);
    states[1311] = new State(-359);
    states[1312] = new State(-367);
    states[1313] = new State(new int[]{105,1316,11,-368,26,-368,24,-368,42,-368,35,-368,28,-368,29,-368,44,-368,25,-368,90,-368,83,-368,82,-368,81,-368,80,-368,57,-70,27,-70,65,-70,48,-70,51,-70,60,-70,89,-70},new int[]{-172,1314,-43,1189,-39,1192,-61,1315});
    states[1314] = new State(-419);
    states[1315] = new State(-462);
    states[1316] = new State(new int[]{10,1324,141,47,84,49,85,50,79,52,77,53,142,150,144,151,143,153},new int[]{-105,1317,-143,1321,-147,48,-148,51,-161,1322,-163,148,-162,152});
    states[1317] = new State(new int[]{79,1318,10,1323});
    states[1318] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,142,150,144,151,143,153},new int[]{-105,1319,-143,1321,-147,48,-148,51,-161,1322,-163,148,-162,152});
    states[1319] = new State(new int[]{10,1320});
    states[1320] = new State(-455);
    states[1321] = new State(-458);
    states[1322] = new State(-459);
    states[1323] = new State(-456);
    states[1324] = new State(-457);
    states[1325] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,43,385,8,-376,108,-376,10,-376},new int[]{-168,1326,-167,1123,-166,1124,-138,1125,-133,1126,-130,1127,-143,1132,-147,48,-148,51,-187,1133,-331,1135,-145,1139});
    states[1326] = new State(new int[]{8,603,108,-463,10,-463},new int[]{-124,1327});
    states[1327] = new State(new int[]{108,1329,10,1112},new int[]{-203,1328});
    states[1328] = new State(-372);
    states[1329] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,10,-487},new int[]{-256,1330,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[1330] = new State(new int[]{10,1331});
    states[1331] = new State(-420);
    states[1332] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,43,385,8,-376,10,-376},new int[]{-168,1333,-167,1123,-166,1124,-138,1125,-133,1126,-130,1127,-143,1132,-147,48,-148,51,-187,1133,-331,1135,-145,1139});
    states[1333] = new State(new int[]{8,603,10,-463},new int[]{-124,1334});
    states[1334] = new State(new int[]{10,1112},new int[]{-203,1335});
    states[1335] = new State(-374);
    states[1336] = new State(-364);
    states[1337] = new State(-432);
    states[1338] = new State(-365);
    states[1339] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,43,385},new int[]{-166,1340,-138,1125,-133,1126,-130,1127,-143,1132,-147,48,-148,51,-187,1133,-331,1135,-145,1139});
    states[1340] = new State(new int[]{11,1170,5,-389},new int[]{-229,1341,-234,1167});
    states[1341] = new State(new int[]{84,1156,85,1162,10,-396},new int[]{-198,1342});
    states[1342] = new State(new int[]{10,1343});
    states[1343] = new State(new int[]{61,1150,150,1152,149,1153,145,1154,148,1155,11,-386,26,-386,24,-386,42,-386,35,-386,28,-386,29,-386,44,-386,25,-386,90,-386,83,-386,82,-386,81,-386,80,-386},new int[]{-201,1344,-206,1345});
    states[1344] = new State(-378);
    states[1345] = new State(new int[]{10,1346});
    states[1346] = new State(new int[]{61,1150,11,-386,26,-386,24,-386,42,-386,35,-386,28,-386,29,-386,44,-386,25,-386,90,-386,83,-386,82,-386,81,-386,80,-386},new int[]{-201,1347});
    states[1347] = new State(-379);
    states[1348] = new State(new int[]{44,1349});
    states[1349] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,43,385},new int[]{-166,1350,-138,1125,-133,1126,-130,1127,-143,1132,-147,48,-148,51,-187,1133,-331,1135,-145,1139});
    states[1350] = new State(new int[]{11,1170,5,-389},new int[]{-229,1351,-234,1167});
    states[1351] = new State(new int[]{108,1185,10,-385},new int[]{-207,1352});
    states[1352] = new State(new int[]{10,1353});
    states[1353] = new State(-382);
    states[1354] = new State(new int[]{11,640,90,-342,83,-342,82,-342,81,-342,80,-342,26,-211,24,-211,42,-211,35,-211,28,-211,29,-211,44,-211,25,-211},new int[]{-54,518,-53,519,-6,520,-246,1094,-55,1355});
    states[1355] = new State(-354);
    states[1356] = new State(-351);
    states[1357] = new State(-308);
    states[1358] = new State(-309);
    states[1359] = new State(new int[]{24,1360,46,1361,41,1362,8,-310,21,-310,11,-310,90,-310,83,-310,82,-310,81,-310,80,-310,27,-310,141,-310,84,-310,85,-310,79,-310,77,-310,60,-310,26,-310,42,-310,35,-310,28,-310,29,-310,44,-310,25,-310,10,-310});
    states[1360] = new State(-311);
    states[1361] = new State(-312);
    states[1362] = new State(-313);
    states[1363] = new State(new int[]{67,1365,68,1366,145,1367,25,1368,26,1369,24,-305,41,-305,62,-305},new int[]{-20,1364});
    states[1364] = new State(-307);
    states[1365] = new State(-299);
    states[1366] = new State(-300);
    states[1367] = new State(-301);
    states[1368] = new State(-302);
    states[1369] = new State(-303);
    states[1370] = new State(-306);
    states[1371] = new State(new int[]{121,1373,118,-219},new int[]{-151,1372});
    states[1372] = new State(-220);
    states[1373] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-154,1374,-143,796,-147,48,-148,51});
    states[1374] = new State(new int[]{120,1375,119,1131,98,580});
    states[1375] = new State(-221);
    states[1376] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616,67,1365,68,1366,145,1367,25,1368,26,1369,24,-304,41,-304,62,-304},new int[]{-283,1377,-272,1230,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600,-30,1231,-21,1232,-22,1363,-20,1370});
    states[1377] = new State(new int[]{10,1378});
    states[1378] = new State(-218);
    states[1379] = new State(new int[]{11,640,141,-211,84,-211,85,-211,79,-211,77,-211},new int[]{-49,1380,-6,1224,-246,1094});
    states[1380] = new State(-105);
    states[1381] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,8,1386,57,-91,27,-91,65,-91,48,-91,51,-91,60,-91,89,-91},new int[]{-310,1382,-307,1383,-308,1384,-154,797,-143,796,-147,48,-148,51});
    states[1382] = new State(-111);
    states[1383] = new State(-107);
    states[1384] = new State(new int[]{10,1385});
    states[1385] = new State(-403);
    states[1386] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-143,1387,-147,48,-148,51});
    states[1387] = new State(new int[]{98,1388});
    states[1388] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-154,1389,-143,796,-147,48,-148,51});
    states[1389] = new State(new int[]{9,1390,98,580});
    states[1390] = new State(new int[]{108,1391});
    states[1391] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550},new int[]{-98,1392,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549});
    states[1392] = new State(new int[]{10,1393});
    states[1393] = new State(-108);
    states[1394] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,8,1386},new int[]{-310,1395,-307,1383,-308,1384,-154,797,-143,796,-147,48,-148,51});
    states[1395] = new State(-109);
    states[1396] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,8,1386},new int[]{-310,1397,-307,1383,-308,1384,-154,797,-143,796,-147,48,-148,51});
    states[1397] = new State(-110);
    states[1398] = new State(-244);
    states[1399] = new State(-245);
    states[1400] = new State(new int[]{125,492,119,-246,98,-246,118,-246,9,-246,8,-246,136,-246,134,-246,116,-246,115,-246,129,-246,130,-246,131,-246,132,-246,128,-246,114,-246,113,-246,126,-246,127,-246,124,-246,6,-246,5,-246,123,-246,121,-246,122,-246,120,-246,135,-246,16,-246,90,-246,10,-246,96,-246,99,-246,31,-246,102,-246,2,-246,12,-246,97,-246,30,-246,84,-246,83,-246,82,-246,81,-246,80,-246,85,-246,13,-246,75,-246,49,-246,56,-246,139,-246,141,-246,79,-246,77,-246,43,-246,40,-246,19,-246,20,-246,142,-246,144,-246,143,-246,152,-246,155,-246,154,-246,153,-246,55,-246,89,-246,38,-246,23,-246,95,-246,52,-246,33,-246,53,-246,100,-246,45,-246,34,-246,51,-246,58,-246,73,-246,71,-246,36,-246,69,-246,70,-246,108,-246});
    states[1401] = new State(-676);
    states[1402] = new State(new int[]{8,1403});
    states[1403] = new State(new int[]{14,476,142,150,144,151,143,153,152,155,155,156,154,157,153,158,51,478,141,47,84,49,85,50,79,52,77,53,11,912,8,925},new int[]{-350,1404,-348,1410,-15,477,-161,147,-163,148,-162,152,-16,154,-337,1401,-280,1402,-176,164,-143,201,-147,48,-148,51,-340,1408,-341,1409});
    states[1404] = new State(new int[]{9,1405,10,474,98,1406});
    states[1405] = new State(-634);
    states[1406] = new State(new int[]{14,476,142,150,144,151,143,153,152,155,155,156,154,157,153,158,51,478,141,47,84,49,85,50,79,52,77,53,11,912,8,925},new int[]{-348,1407,-15,477,-161,147,-163,148,-162,152,-16,154,-337,1401,-280,1402,-176,164,-143,201,-147,48,-148,51,-340,1408,-341,1409});
    states[1407] = new State(-671);
    states[1408] = new State(-677);
    states[1409] = new State(-678);
    states[1410] = new State(-669);
    states[1411] = new State(new int[]{5,656,125,-986},new int[]{-322,1412});
    states[1412] = new State(new int[]{125,1413});
    states[1413] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,445,19,264,20,269,75,456,18,669,35,678,42,684,89,17,38,712,52,748,95,743,33,753,34,779,71,850,23,727,100,769,58,858,45,776,73,972},new int[]{-325,1414,-101,442,-96,443,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,682,-113,542,-319,683,-97,654,-320,677,-327,844,-251,710,-149,711,-315,845,-243,846,-120,847,-119,848,-121,849,-35,967,-298,968,-165,969,-244,970,-122,971});
    states[1414] = new State(-965);
    states[1415] = new State(new int[]{5,1416,10,1428,8,-776,7,-776,140,-776,4,-776,15,-776,136,-776,134,-776,116,-776,115,-776,129,-776,130,-776,131,-776,132,-776,128,-776,114,-776,113,-776,126,-776,127,-776,124,-776,6,-776,118,-776,123,-776,121,-776,119,-776,122,-776,120,-776,135,-776,16,-776,9,-776,98,-776,13,-776,117,-776,11,-776,17,-776});
    states[1416] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-271,1417,-272,500,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[1417] = new State(new int[]{9,1418,10,1422});
    states[1418] = new State(new int[]{5,656,125,-986},new int[]{-322,1419});
    states[1419] = new State(new int[]{125,1420});
    states[1420] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,445,19,264,20,269,75,456,18,669,35,678,42,684,89,17,38,712,52,748,95,743,33,753,34,779,71,850,23,727,100,769,58,858,45,776,73,972},new int[]{-325,1421,-101,442,-96,443,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,682,-113,542,-319,683,-97,654,-320,677,-327,844,-251,710,-149,711,-315,845,-243,846,-120,847,-119,848,-121,849,-35,967,-298,968,-165,969,-244,970,-122,971});
    states[1421] = new State(-966);
    states[1422] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-323,1423,-324,1077,-154,578,-143,796,-147,48,-148,51});
    states[1423] = new State(new int[]{9,1424,10,576});
    states[1424] = new State(new int[]{5,656,125,-986},new int[]{-322,1425});
    states[1425] = new State(new int[]{125,1426});
    states[1426] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,445,19,264,20,269,75,456,18,669,35,678,42,684,89,17,38,712,52,748,95,743,33,753,34,779,71,850,23,727,100,769,58,858,45,776,73,972},new int[]{-325,1427,-101,442,-96,443,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,682,-113,542,-319,683,-97,654,-320,677,-327,844,-251,710,-149,711,-315,845,-243,846,-120,847,-119,848,-121,849,-35,967,-298,968,-165,969,-244,970,-122,971});
    states[1427] = new State(-968);
    states[1428] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-323,1429,-324,1077,-154,578,-143,796,-147,48,-148,51});
    states[1429] = new State(new int[]{9,1430,10,576});
    states[1430] = new State(new int[]{5,656,125,-986},new int[]{-322,1431});
    states[1431] = new State(new int[]{125,1432});
    states[1432] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,445,19,264,20,269,75,456,18,669,35,678,42,684,89,17,38,712,52,748,95,743,33,753,34,779,71,850,23,727,100,769,58,858,45,776,73,972},new int[]{-325,1433,-101,442,-96,443,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,682,-113,542,-319,683,-97,654,-320,677,-327,844,-251,710,-149,711,-315,845,-243,846,-120,847,-119,848,-121,849,-35,967,-298,968,-165,969,-244,970,-122,971});
    states[1433] = new State(-967);
    states[1434] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,5,559},new int[]{-116,1435,-102,565,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,563,-263,540});
    states[1435] = new State(new int[]{12,1436});
    states[1436] = new State(-785);
    states[1437] = new State(-764);
    states[1438] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,660,12,-280,98,-280},new int[]{-267,1439,-268,1440,-90,177,-103,284,-104,285,-176,485,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152});
    states[1439] = new State(-278);
    states[1440] = new State(-279);
    states[1441] = new State(-277);
    states[1442] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-272,1443,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[1443] = new State(-276);
    states[1444] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,22,330},new int[]{-280,1445,-274,1446,-176,164,-143,201,-147,48,-148,51,-266,504});
    states[1445] = new State(-722);
    states[1446] = new State(-723);
    states[1447] = new State(-736);
    states[1448] = new State(-737);
    states[1449] = new State(-738);
    states[1450] = new State(-739);
    states[1451] = new State(-740);
    states[1452] = new State(-741);
    states[1453] = new State(-742);
    states[1454] = new State(-239);
    states[1455] = new State(-235);
    states[1456] = new State(-614);
    states[1457] = new State(new int[]{8,1458});
    states[1458] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,43,385,40,423,8,425,19,264,20,269,75,456},new int[]{-330,1459,-329,1467,-143,1463,-147,48,-148,51,-95,1466,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540});
    states[1459] = new State(new int[]{9,1460,98,1461});
    states[1460] = new State(-623);
    states[1461] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,43,385,40,423,8,425,19,264,20,269,75,456},new int[]{-329,1462,-143,1463,-147,48,-148,51,-95,1466,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540});
    states[1462] = new State(-627);
    states[1463] = new State(new int[]{108,1464,8,-776,7,-776,140,-776,4,-776,15,-776,136,-776,134,-776,116,-776,115,-776,129,-776,130,-776,131,-776,132,-776,128,-776,114,-776,113,-776,126,-776,127,-776,124,-776,6,-776,118,-776,123,-776,121,-776,119,-776,122,-776,120,-776,135,-776,9,-776,98,-776,117,-776,11,-776,17,-776});
    states[1464] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456},new int[]{-95,1465,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540});
    states[1465] = new State(new int[]{118,308,123,309,121,310,119,311,122,312,120,313,135,314,9,-624,98,-624},new int[]{-192,32});
    states[1466] = new State(new int[]{118,308,123,309,121,310,119,311,122,312,120,313,135,314,9,-625,98,-625},new int[]{-192,32});
    states[1467] = new State(-626);
    states[1468] = new State(new int[]{13,189,16,193,5,-691,12,-691});
    states[1469] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160},new int[]{-87,1470,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840});
    states[1470] = new State(new int[]{13,189,16,193,98,-188,9,-188,12,-188,5,-188});
    states[1471] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160,5,-692,12,-692},new int[]{-118,1472,-87,1468,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840});
    states[1472] = new State(new int[]{5,1473,12,-698});
    states[1473] = new State(new int[]{141,47,84,49,85,50,79,52,77,244,142,150,144,151,143,153,152,155,155,156,154,157,153,158,40,261,19,264,20,269,11,343,75,806,54,809,139,810,8,823,133,826,114,362,113,363,61,160},new int[]{-87,1474,-88,219,-79,227,-13,232,-10,242,-14,205,-143,243,-147,48,-148,51,-161,259,-163,148,-162,152,-16,260,-253,263,-291,268,-235,342,-195,832,-169,830,-57,831,-261,838,-265,839,-11,834,-237,840});
    states[1474] = new State(new int[]{13,189,16,193,12,-700});
    states[1475] = new State(-185);
    states[1476] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153},new int[]{-90,1477,-103,284,-104,285,-176,485,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152});
    states[1477] = new State(new int[]{114,228,113,229,126,230,127,231,13,-248,119,-248,98,-248,118,-248,9,-248,8,-248,136,-248,134,-248,116,-248,115,-248,129,-248,130,-248,131,-248,132,-248,128,-248,124,-248,6,-248,5,-248,123,-248,121,-248,122,-248,120,-248,135,-248,16,-248,90,-248,10,-248,96,-248,99,-248,31,-248,102,-248,2,-248,12,-248,97,-248,30,-248,84,-248,83,-248,82,-248,81,-248,80,-248,85,-248,75,-248,49,-248,56,-248,139,-248,141,-248,79,-248,77,-248,43,-248,40,-248,19,-248,20,-248,142,-248,144,-248,143,-248,152,-248,155,-248,154,-248,153,-248,55,-248,89,-248,38,-248,23,-248,95,-248,52,-248,33,-248,53,-248,100,-248,45,-248,34,-248,51,-248,58,-248,73,-248,71,-248,36,-248,69,-248,70,-248,125,-248,108,-248},new int[]{-189,178});
    states[1478] = new State(-712);
    states[1479] = new State(-632);
    states[1480] = new State(-35);
    states[1481] = new State(new int[]{57,1195,27,1216,65,1220,48,1379,51,1394,60,1396,11,640,89,-64,90,-64,101,-64,42,-211,35,-211,26,-211,24,-211,28,-211,29,-211},new int[]{-47,1482,-164,1483,-29,1484,-52,1485,-285,1486,-306,1487,-216,1488,-6,1489,-246,1094});
    states[1482] = new State(-68);
    states[1483] = new State(-78);
    states[1484] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,57,-79,27,-79,65,-79,48,-79,51,-79,60,-79,11,-79,42,-79,35,-79,26,-79,24,-79,28,-79,29,-79,89,-79,90,-79,101,-79},new int[]{-27,1202,-28,1203,-137,1205,-143,1215,-147,48,-148,51});
    states[1485] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,57,-80,27,-80,65,-80,48,-80,51,-80,60,-80,11,-80,42,-80,35,-80,26,-80,24,-80,28,-80,29,-80,89,-80,90,-80,101,-80},new int[]{-27,1219,-28,1203,-137,1205,-143,1215,-147,48,-148,51});
    states[1486] = new State(new int[]{11,640,57,-81,27,-81,65,-81,48,-81,51,-81,60,-81,42,-81,35,-81,26,-81,24,-81,28,-81,29,-81,89,-81,90,-81,101,-81,141,-211,84,-211,85,-211,79,-211,77,-211},new int[]{-49,1223,-6,1224,-246,1094});
    states[1487] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,8,1386,57,-82,27,-82,65,-82,48,-82,51,-82,60,-82,11,-82,42,-82,35,-82,26,-82,24,-82,28,-82,29,-82,89,-82,90,-82,101,-82},new int[]{-310,1382,-307,1383,-308,1384,-154,797,-143,796,-147,48,-148,51});
    states[1488] = new State(-83);
    states[1489] = new State(new int[]{42,1502,35,1509,27,1526,26,1310,24,1311,28,1539,29,1332,11,640},new int[]{-209,1490,-246,522,-210,1491,-217,1492,-224,1493,-221,1257,-225,1292,-3,1528,-213,1536,-223,1537});
    states[1490] = new State(-86);
    states[1491] = new State(-84);
    states[1492] = new State(-422);
    states[1493] = new State(new int[]{146,1495,105,1316,57,-67,27,-67,65,-67,48,-67,51,-67,60,-67,11,-67,42,-67,35,-67,26,-67,24,-67,28,-67,29,-67,89,-67},new int[]{-174,1494,-173,1497,-41,1498,-42,1481,-61,1501});
    states[1494] = new State(-424);
    states[1495] = new State(new int[]{10,1496});
    states[1496] = new State(-430);
    states[1497] = new State(-438);
    states[1498] = new State(new int[]{89,17},new int[]{-251,1499});
    states[1499] = new State(new int[]{10,1500});
    states[1500] = new State(-460);
    states[1501] = new State(-439);
    states[1502] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,43,385},new int[]{-167,1503,-166,1124,-138,1125,-133,1126,-130,1127,-143,1132,-147,48,-148,51,-187,1133,-331,1135,-145,1139});
    states[1503] = new State(new int[]{8,603,10,-463,108,-463},new int[]{-124,1504});
    states[1504] = new State(new int[]{10,1290,108,-809},new int[]{-203,1261,-204,1505});
    states[1505] = new State(new int[]{108,1506});
    states[1506] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,10,-487},new int[]{-256,1507,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[1507] = new State(new int[]{10,1508});
    states[1508] = new State(-429);
    states[1509] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,43,385},new int[]{-166,1510,-138,1125,-133,1126,-130,1127,-143,1132,-147,48,-148,51,-187,1133,-331,1135,-145,1139});
    states[1510] = new State(new int[]{8,603,5,-463,10,-463,108,-463},new int[]{-124,1511});
    states[1511] = new State(new int[]{5,1512,10,1290,108,-809},new int[]{-203,1296,-204,1520});
    states[1512] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-271,1513,-272,500,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[1513] = new State(new int[]{10,1290,108,-809},new int[]{-203,1300,-204,1514});
    states[1514] = new State(new int[]{108,1515});
    states[1515] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,445,19,264,20,269,75,456,38,550,18,669,35,678,42,684},new int[]{-98,1516,-319,1518,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-97,654,-320,677});
    states[1516] = new State(new int[]{10,1517});
    states[1517] = new State(-425);
    states[1518] = new State(new int[]{10,1519});
    states[1519] = new State(-427);
    states[1520] = new State(new int[]{108,1521});
    states[1521] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,445,19,264,20,269,75,456,38,550,18,669,35,678,42,684},new int[]{-98,1522,-319,1524,-96,29,-95,307,-102,444,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,439,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-97,654,-320,677});
    states[1522] = new State(new int[]{10,1523});
    states[1523] = new State(-426);
    states[1524] = new State(new int[]{10,1525});
    states[1525] = new State(-428);
    states[1526] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-27,1527,-28,1203,-137,1205,-143,1215,-147,48,-148,51});
    states[1527] = new State(-431);
    states[1528] = new State(new int[]{28,1530,42,1502,35,1509,27,1526},new int[]{-217,1529,-224,1493,-221,1257,-225,1292});
    states[1529] = new State(-423);
    states[1530] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,43,385,8,-376,108,-376,10,-376},new int[]{-168,1531,-167,1123,-166,1124,-138,1125,-133,1126,-130,1127,-143,1132,-147,48,-148,51,-187,1133,-331,1135,-145,1139});
    states[1531] = new State(new int[]{8,603,108,-463,10,-463},new int[]{-124,1532});
    states[1532] = new State(new int[]{108,1533,10,1112},new int[]{-203,530});
    states[1533] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,10,-487},new int[]{-256,1534,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[1534] = new State(new int[]{10,1535});
    states[1535] = new State(-418);
    states[1536] = new State(-85);
    states[1537] = new State(-67,new int[]{-173,1538,-41,1498,-42,1481});
    states[1538] = new State(-416);
    states[1539] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,43,385,8,-376,108,-376,10,-376},new int[]{-168,1540,-167,1123,-166,1124,-138,1125,-133,1126,-130,1127,-143,1132,-147,48,-148,51,-187,1133,-331,1135,-145,1139});
    states[1540] = new State(new int[]{8,603,108,-463,10,-463},new int[]{-124,1541});
    states[1541] = new State(new int[]{108,1542,10,1112},new int[]{-203,1328});
    states[1542] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,155,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,10,-487},new int[]{-256,1543,-4,23,-109,24,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871});
    states[1543] = new State(new int[]{10,1544});
    states[1544] = new State(-417);
    states[1545] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,83,56,82,57,81,58,80,59,67,60,62,61,126,62,20,63,19,64,61,65,21,66,127,67,128,68,129,69,130,70,131,71,132,72,133,73,134,74,135,75,136,76,22,77,72,78,89,79,23,80,24,81,27,82,28,83,29,84,70,85,97,86,30,87,90,88,31,89,32,90,25,91,102,92,99,93,33,94,34,95,35,96,38,97,39,98,40,99,101,100,41,101,42,102,44,103,45,104,46,105,95,106,47,107,100,108,48,109,26,110,49,111,69,112,96,113,50,114,51,115,52,116,53,117,54,118,55,119,56,120,57,121,59,122,103,123,104,124,107,125,105,126,106,127,60,128,73,129,36,130,37,131,68,132,145,133,58,134,137,135,138,136,78,137,150,138,149,139,71,140,151,141,147,142,148,143,146,144,43,146},new int[]{-300,1546,-304,1556,-153,1550,-134,1555,-143,46,-147,48,-148,51,-289,54,-146,55,-290,145});
    states[1546] = new State(new int[]{10,1547,98,1548});
    states[1547] = new State(-38);
    states[1548] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,83,56,82,57,81,58,80,59,67,60,62,61,126,62,20,63,19,64,61,65,21,66,127,67,128,68,129,69,130,70,131,71,132,72,133,73,134,74,135,75,136,76,22,77,72,78,89,79,23,80,24,81,27,82,28,83,29,84,70,85,97,86,30,87,90,88,31,89,32,90,25,91,102,92,99,93,33,94,34,95,35,96,38,97,39,98,40,99,101,100,41,101,42,102,44,103,45,104,46,105,95,106,47,107,100,108,48,109,26,110,49,111,69,112,96,113,50,114,51,115,52,116,53,117,54,118,55,119,56,120,57,121,59,122,103,123,104,124,107,125,105,126,106,127,60,128,73,129,36,130,37,131,68,132,145,133,58,134,137,135,138,136,78,137,150,138,149,139,71,140,151,141,147,142,148,143,146,144,43,146},new int[]{-304,1549,-153,1550,-134,1555,-143,46,-147,48,-148,51,-289,54,-146,55,-290,145});
    states[1549] = new State(-44);
    states[1550] = new State(new int[]{7,1551,135,1553,10,-45,98,-45});
    states[1551] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,83,56,82,57,81,58,80,59,67,60,62,61,126,62,20,63,19,64,61,65,21,66,127,67,128,68,129,69,130,70,131,71,132,72,133,73,134,74,135,75,136,76,22,77,72,78,89,79,23,80,24,81,27,82,28,83,29,84,70,85,97,86,30,87,90,88,31,89,32,90,25,91,102,92,99,93,33,94,34,95,35,96,38,97,39,98,40,99,101,100,41,101,42,102,44,103,45,104,46,105,95,106,47,107,100,108,48,109,26,110,49,111,69,112,96,113,50,114,51,115,52,116,53,117,54,118,55,119,56,120,57,121,59,122,103,123,104,124,107,125,105,126,106,127,60,128,73,129,36,130,37,131,68,132,145,133,58,134,137,135,138,136,78,137,150,138,149,139,71,140,151,141,147,142,148,143,146,144,43,146},new int[]{-134,1552,-143,46,-147,48,-148,51,-289,54,-146,55,-290,145});
    states[1552] = new State(-37);
    states[1553] = new State(new int[]{142,1554});
    states[1554] = new State(-46);
    states[1555] = new State(-36);
    states[1556] = new State(-43);
    states[1557] = new State(new int[]{3,1559,50,-15,89,-15,57,-15,27,-15,65,-15,48,-15,51,-15,60,-15,11,-15,42,-15,35,-15,26,-15,24,-15,28,-15,29,-15,41,-15,90,-15,101,-15},new int[]{-180,1558});
    states[1558] = new State(-17);
    states[1559] = new State(new int[]{141,1560,142,1561});
    states[1560] = new State(-18);
    states[1561] = new State(-19);
    states[1562] = new State(-16);
    states[1563] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-143,1564,-147,48,-148,51});
    states[1564] = new State(new int[]{10,1566,8,1567},new int[]{-183,1565});
    states[1565] = new State(-28);
    states[1566] = new State(-29);
    states[1567] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-185,1568,-142,1574,-143,1573,-147,48,-148,51});
    states[1568] = new State(new int[]{9,1569,98,1571});
    states[1569] = new State(new int[]{10,1570});
    states[1570] = new State(-30);
    states[1571] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-142,1572,-143,1573,-147,48,-148,51});
    states[1572] = new State(-32);
    states[1573] = new State(-33);
    states[1574] = new State(-31);
    states[1575] = new State(-3);
    states[1576] = new State(new int[]{103,1631,104,1632,107,1633,11,640},new int[]{-305,1577,-246,522,-2,1626});
    states[1577] = new State(new int[]{41,1598,50,-41,57,-41,27,-41,65,-41,48,-41,51,-41,60,-41,11,-41,42,-41,35,-41,26,-41,24,-41,28,-41,29,-41,90,-41,101,-41,89,-41},new int[]{-158,1578,-159,1595,-299,1624});
    states[1578] = new State(new int[]{39,1592},new int[]{-157,1579});
    states[1579] = new State(new int[]{90,1582,101,1583,89,1589},new int[]{-150,1580});
    states[1580] = new State(new int[]{7,1581});
    states[1581] = new State(-47);
    states[1582] = new State(-57);
    states[1583] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,741,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,90,-487,102,-487,10,-487},new int[]{-248,1584,-257,739,-256,22,-4,23,-109,24,-128,367,-108,534,-143,740,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871,-139,1026});
    states[1584] = new State(new int[]{90,1585,102,1586,10,20});
    states[1585] = new State(-58);
    states[1586] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,741,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,90,-487,10,-487},new int[]{-248,1587,-257,739,-256,22,-4,23,-109,24,-128,367,-108,534,-143,740,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871,-139,1026});
    states[1587] = new State(new int[]{90,1588,10,20});
    states[1588] = new State(-59);
    states[1589] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,741,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,90,-487,10,-487},new int[]{-248,1590,-257,739,-256,22,-4,23,-109,24,-128,367,-108,534,-143,740,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871,-139,1026});
    states[1590] = new State(new int[]{90,1591,10,20});
    states[1591] = new State(-60);
    states[1592] = new State(-41,new int[]{-299,1593});
    states[1593] = new State(new int[]{50,1545,57,-67,27,-67,65,-67,48,-67,51,-67,60,-67,11,-67,42,-67,35,-67,26,-67,24,-67,28,-67,29,-67,90,-67,101,-67,89,-67},new int[]{-41,1594,-301,14,-42,1481});
    states[1594] = new State(-55);
    states[1595] = new State(new int[]{90,1582,101,1583,89,1589},new int[]{-150,1596});
    states[1596] = new State(new int[]{7,1597});
    states[1597] = new State(-48);
    states[1598] = new State(-41,new int[]{-299,1599});
    states[1599] = new State(new int[]{50,1545,27,-62,65,-62,48,-62,51,-62,60,-62,11,-62,42,-62,35,-62,39,-62},new int[]{-40,1600,-301,14,-38,1601});
    states[1600] = new State(-54);
    states[1601] = new State(new int[]{27,1216,65,1220,48,1379,51,1394,60,1396,11,640,39,-61,42,-211,35,-211},new int[]{-48,1602,-29,1603,-52,1604,-285,1605,-306,1606,-228,1607,-6,1608,-246,1094,-227,1623});
    states[1602] = new State(-63);
    states[1603] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,27,-72,65,-72,48,-72,51,-72,60,-72,11,-72,42,-72,35,-72,39,-72},new int[]{-27,1202,-28,1203,-137,1205,-143,1215,-147,48,-148,51});
    states[1604] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,27,-73,65,-73,48,-73,51,-73,60,-73,11,-73,42,-73,35,-73,39,-73},new int[]{-27,1219,-28,1203,-137,1205,-143,1215,-147,48,-148,51});
    states[1605] = new State(new int[]{11,640,27,-74,65,-74,48,-74,51,-74,60,-74,42,-74,35,-74,39,-74,141,-211,84,-211,85,-211,79,-211,77,-211},new int[]{-49,1223,-6,1224,-246,1094});
    states[1606] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,8,1386,27,-75,65,-75,48,-75,51,-75,60,-75,11,-75,42,-75,35,-75,39,-75},new int[]{-310,1382,-307,1383,-308,1384,-154,797,-143,796,-147,48,-148,51});
    states[1607] = new State(-76);
    states[1608] = new State(new int[]{42,1615,11,640,35,1618},new int[]{-221,1609,-246,522,-225,1612});
    states[1609] = new State(new int[]{146,1610,27,-92,65,-92,48,-92,51,-92,60,-92,11,-92,42,-92,35,-92,39,-92});
    states[1610] = new State(new int[]{10,1611});
    states[1611] = new State(-93);
    states[1612] = new State(new int[]{146,1613,27,-94,65,-94,48,-94,51,-94,60,-94,11,-94,42,-94,35,-94,39,-94});
    states[1613] = new State(new int[]{10,1614});
    states[1614] = new State(-95);
    states[1615] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,43,385},new int[]{-167,1616,-166,1124,-138,1125,-133,1126,-130,1127,-143,1132,-147,48,-148,51,-187,1133,-331,1135,-145,1139});
    states[1616] = new State(new int[]{8,603,10,-463},new int[]{-124,1617});
    states[1617] = new State(new int[]{10,1112},new int[]{-203,1261});
    states[1618] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,43,385},new int[]{-166,1619,-138,1125,-133,1126,-130,1127,-143,1132,-147,48,-148,51,-187,1133,-331,1135,-145,1139});
    states[1619] = new State(new int[]{8,603,5,-463,10,-463},new int[]{-124,1620});
    states[1620] = new State(new int[]{5,1621,10,1112},new int[]{-203,1296});
    states[1621] = new State(new int[]{141,338,84,49,85,50,79,52,77,53,152,155,155,156,154,157,153,158,114,362,113,363,142,150,144,151,143,153,8,487,140,498,22,330,46,506,47,585,32,589,72,593,63,596,42,601,35,616},new int[]{-271,1622,-272,500,-268,336,-90,177,-103,284,-104,285,-176,286,-143,201,-147,48,-148,51,-16,482,-195,483,-161,486,-163,148,-162,152,-269,489,-297,490,-252,496,-245,497,-277,501,-278,502,-274,503,-266,504,-31,505,-259,584,-126,588,-127,592,-222,598,-220,599,-219,600});
    states[1622] = new State(new int[]{10,1112},new int[]{-203,1300});
    states[1623] = new State(-77);
    states[1624] = new State(new int[]{50,1545,57,-67,27,-67,65,-67,48,-67,51,-67,60,-67,11,-67,42,-67,35,-67,26,-67,24,-67,28,-67,29,-67,90,-67,101,-67,89,-67},new int[]{-41,1625,-301,14,-42,1481});
    states[1625] = new State(-56);
    states[1626] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-135,1627,-143,1630,-147,48,-148,51});
    states[1627] = new State(new int[]{10,1628});
    states[1628] = new State(new int[]{3,1559,41,-14,90,-14,101,-14,89,-14,50,-14,57,-14,27,-14,65,-14,48,-14,51,-14,60,-14,11,-14,42,-14,35,-14,26,-14,24,-14,28,-14,29,-14},new int[]{-181,1629,-182,1557,-180,1562});
    states[1629] = new State(-49);
    states[1630] = new State(-53);
    states[1631] = new State(-51);
    states[1632] = new State(-52);
    states[1633] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,83,56,82,57,81,58,80,59,67,60,62,61,126,62,20,63,19,64,61,65,21,66,127,67,128,68,129,69,130,70,131,71,132,72,133,73,134,74,135,75,136,76,22,77,72,78,89,79,23,80,24,81,27,82,28,83,29,84,70,85,97,86,30,87,90,88,31,89,32,90,25,91,102,92,99,93,33,94,34,95,35,96,38,97,39,98,40,99,101,100,41,101,42,102,44,103,45,104,46,105,95,106,47,107,100,108,48,109,26,110,49,111,69,112,96,113,50,114,51,115,52,116,53,117,54,118,55,119,56,120,57,121,59,122,103,123,104,124,107,125,105,126,106,127,60,128,73,129,36,130,37,131,68,132,145,133,58,134,137,135,138,136,78,137,150,138,149,139,71,140,151,141,147,142,148,143,146,144,43,146},new int[]{-153,1634,-134,1555,-143,46,-147,48,-148,51,-289,54,-146,55,-290,145});
    states[1634] = new State(new int[]{10,1635,7,1551});
    states[1635] = new State(new int[]{3,1559,41,-14,90,-14,101,-14,89,-14,50,-14,57,-14,27,-14,65,-14,48,-14,51,-14,60,-14,11,-14,42,-14,35,-14,26,-14,24,-14,28,-14,29,-14},new int[]{-181,1636,-182,1557,-180,1562});
    states[1636] = new State(-50);
    states[1637] = new State(-4);
    states[1638] = new State(new int[]{48,1640,54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,425,19,264,20,269,75,456,38,550,5,559},new int[]{-85,1639,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,377,-128,367,-108,379,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558});
    states[1639] = new State(-7);
    states[1640] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-140,1641,-143,1642,-147,48,-148,51});
    states[1641] = new State(-8);
    states[1642] = new State(new int[]{121,1129,2,-219},new int[]{-151,1372});
    states[1643] = new State(new int[]{141,47,84,49,85,50,79,52,77,53},new int[]{-317,1644,-318,1645,-143,1649,-147,48,-148,51});
    states[1644] = new State(-9);
    states[1645] = new State(new int[]{7,1646,121,170,2,-769},new int[]{-295,1648});
    states[1646] = new State(new int[]{141,47,84,49,85,50,79,52,77,53,83,56,82,57,81,58,80,59,67,60,62,61,126,62,20,63,19,64,61,65,21,66,127,67,128,68,129,69,130,70,131,71,132,72,133,73,134,74,135,75,136,76,22,77,72,78,89,79,23,80,24,81,27,82,28,83,29,84,70,85,97,86,30,87,90,88,31,89,32,90,25,91,102,92,99,93,33,94,34,95,35,96,38,97,39,98,40,99,101,100,41,101,42,102,44,103,45,104,46,105,95,106,47,107,100,108,48,109,26,110,49,111,69,112,96,113,50,114,51,115,52,116,53,117,54,118,55,119,56,120,57,121,59,122,103,123,104,124,107,125,105,126,106,127,60,128,73,129,36,130,37,131,68,132,145,133,58,134,137,135,138,136,78,137,150,138,149,139,71,140,151,141,147,142,148,143,146,144,43,146},new int[]{-134,1647,-143,46,-147,48,-148,51,-289,54,-146,55,-290,145});
    states[1647] = new State(-768);
    states[1648] = new State(-770);
    states[1649] = new State(-767);
    states[1650] = new State(new int[]{54,42,142,150,144,151,143,153,152,155,155,156,154,157,153,158,61,160,11,353,133,357,114,362,113,363,140,364,139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,423,8,567,19,264,20,269,75,456,38,550,5,559,51,787},new int[]{-255,1651,-85,1652,-98,28,-96,29,-95,307,-102,315,-81,320,-80,326,-93,352,-15,43,-161,147,-163,148,-162,152,-16,154,-57,159,-195,375,-109,1653,-128,367,-108,534,-143,421,-147,48,-148,51,-187,422,-253,432,-291,433,-17,434,-58,459,-112,462,-169,463,-264,464,-94,465,-260,469,-262,470,-263,540,-236,541,-113,542,-238,549,-116,558,-4,1654,-311,1655});
    states[1651] = new State(-10);
    states[1652] = new State(-11);
    states[1653] = new State(new int[]{108,409,109,410,110,411,111,412,112,413,136,-754,134,-754,116,-754,115,-754,129,-754,130,-754,131,-754,132,-754,128,-754,114,-754,113,-754,126,-754,127,-754,124,-754,6,-754,5,-754,118,-754,123,-754,121,-754,119,-754,122,-754,120,-754,135,-754,16,-754,2,-754,13,-754,117,-746},new int[]{-190,25});
    states[1654] = new State(-12);
    states[1655] = new State(-13);
    states[1656] = new State(new int[]{50,1545,139,-39,141,-39,84,-39,85,-39,79,-39,77,-39,43,-39,40,-39,8,-39,19,-39,20,-39,142,-39,144,-39,143,-39,152,-39,155,-39,154,-39,153,-39,75,-39,55,-39,89,-39,38,-39,23,-39,95,-39,52,-39,33,-39,53,-39,100,-39,45,-39,34,-39,51,-39,58,-39,73,-39,71,-39,36,-39,42,-39,35,-39,27,-39,10,-39,2,-39},new int[]{-302,1657,-301,1661});
    states[1657] = new State(-65,new int[]{-44,1658});
    states[1658] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,741,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,42,1502,35,1509,27,1526,10,-487,2,-487},new int[]{-248,1659,-217,1660,-257,739,-256,22,-4,23,-109,24,-128,367,-108,534,-143,740,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871,-139,1026,-224,1493,-221,1257,-225,1292});
    states[1659] = new State(new int[]{10,20,2,-5});
    states[1660] = new State(-66);
    states[1661] = new State(-40);
    states[1662] = new State(new int[]{50,1545,139,-39,141,-39,84,-39,85,-39,79,-39,77,-39,43,-39,40,-39,8,-39,19,-39,20,-39,142,-39,144,-39,143,-39,152,-39,155,-39,154,-39,153,-39,75,-39,55,-39,89,-39,38,-39,23,-39,95,-39,52,-39,33,-39,53,-39,100,-39,45,-39,34,-39,51,-39,58,-39,73,-39,71,-39,36,-39,42,-39,35,-39,27,-39,10,-39,2,-39},new int[]{-302,1663,-301,1661});
    states[1663] = new State(-65,new int[]{-44,1664});
    states[1664] = new State(new int[]{139,378,141,47,84,49,85,50,79,52,77,244,43,385,40,566,8,567,19,264,20,269,142,150,144,151,143,153,152,741,155,156,154,157,153,158,75,456,55,720,89,17,38,712,23,727,95,743,52,748,33,753,53,763,100,769,45,776,34,779,51,787,58,858,73,863,71,850,36,872,42,1502,35,1509,27,1526,10,-487,2,-487},new int[]{-248,1665,-217,1660,-257,739,-256,22,-4,23,-109,24,-128,367,-108,534,-143,740,-147,48,-148,51,-187,422,-253,432,-291,433,-15,697,-161,147,-163,148,-162,152,-16,154,-17,434,-58,698,-112,462,-208,718,-129,719,-251,724,-149,725,-35,726,-243,742,-315,747,-120,752,-316,762,-156,767,-298,768,-244,775,-119,778,-311,786,-59,854,-170,855,-169,856,-165,857,-122,862,-123,869,-121,870,-345,871,-139,1026,-224,1493,-221,1257,-225,1292});
    states[1665] = new State(new int[]{10,20,2,-6});

    rules[1] = new Rule(-357, new int[]{-1,2});
    rules[2] = new Rule(-1, new int[]{-230});
    rules[3] = new Rule(-1, new int[]{-303});
    rules[4] = new Rule(-1, new int[]{-171});
    rules[5] = new Rule(-1, new int[]{74,-302,-44,-248});
    rules[6] = new Rule(-1, new int[]{76,-302,-44,-248});
    rules[7] = new Rule(-171, new int[]{86,-85});
    rules[8] = new Rule(-171, new int[]{86,48,-140});
    rules[9] = new Rule(-171, new int[]{88,-317});
    rules[10] = new Rule(-171, new int[]{87,-255});
    rules[11] = new Rule(-255, new int[]{-85});
    rules[12] = new Rule(-255, new int[]{-4});
    rules[13] = new Rule(-255, new int[]{-311});
    rules[14] = new Rule(-181, new int[]{});
    rules[15] = new Rule(-181, new int[]{-182});
    rules[16] = new Rule(-182, new int[]{-180});
    rules[17] = new Rule(-182, new int[]{-182,-180});
    rules[18] = new Rule(-180, new int[]{3,141});
    rules[19] = new Rule(-180, new int[]{3,142});
    rules[20] = new Rule(-230, new int[]{-231,-181,-299,-18,-184});
    rules[21] = new Rule(-184, new int[]{7});
    rules[22] = new Rule(-184, new int[]{10});
    rules[23] = new Rule(-184, new int[]{5});
    rules[24] = new Rule(-184, new int[]{98});
    rules[25] = new Rule(-184, new int[]{6});
    rules[26] = new Rule(-184, new int[]{});
    rules[27] = new Rule(-231, new int[]{});
    rules[28] = new Rule(-231, new int[]{59,-143,-183});
    rules[29] = new Rule(-183, new int[]{10});
    rules[30] = new Rule(-183, new int[]{8,-185,9,10});
    rules[31] = new Rule(-185, new int[]{-142});
    rules[32] = new Rule(-185, new int[]{-185,98,-142});
    rules[33] = new Rule(-142, new int[]{-143});
    rules[34] = new Rule(-18, new int[]{-37,-251});
    rules[35] = new Rule(-37, new int[]{-41});
    rules[36] = new Rule(-153, new int[]{-134});
    rules[37] = new Rule(-153, new int[]{-153,7,-134});
    rules[38] = new Rule(-301, new int[]{50,-300,10});
    rules[39] = new Rule(-302, new int[]{});
    rules[40] = new Rule(-302, new int[]{-301});
    rules[41] = new Rule(-299, new int[]{});
    rules[42] = new Rule(-299, new int[]{-299,-301});
    rules[43] = new Rule(-300, new int[]{-304});
    rules[44] = new Rule(-300, new int[]{-300,98,-304});
    rules[45] = new Rule(-304, new int[]{-153});
    rules[46] = new Rule(-304, new int[]{-153,135,142});
    rules[47] = new Rule(-303, new int[]{-6,-305,-158,-157,-150,7});
    rules[48] = new Rule(-303, new int[]{-6,-305,-159,-150,7});
    rules[49] = new Rule(-305, new int[]{-2,-135,10,-181});
    rules[50] = new Rule(-305, new int[]{107,-153,10,-181});
    rules[51] = new Rule(-2, new int[]{103});
    rules[52] = new Rule(-2, new int[]{104});
    rules[53] = new Rule(-135, new int[]{-143});
    rules[54] = new Rule(-158, new int[]{41,-299,-40});
    rules[55] = new Rule(-157, new int[]{39,-299,-41});
    rules[56] = new Rule(-159, new int[]{-299,-41});
    rules[57] = new Rule(-150, new int[]{90});
    rules[58] = new Rule(-150, new int[]{101,-248,90});
    rules[59] = new Rule(-150, new int[]{101,-248,102,-248,90});
    rules[60] = new Rule(-150, new int[]{89,-248,90});
    rules[61] = new Rule(-40, new int[]{-38});
    rules[62] = new Rule(-38, new int[]{});
    rules[63] = new Rule(-38, new int[]{-38,-48});
    rules[64] = new Rule(-41, new int[]{-42});
    rules[65] = new Rule(-44, new int[]{});
    rules[66] = new Rule(-44, new int[]{-44,-217});
    rules[67] = new Rule(-42, new int[]{});
    rules[68] = new Rule(-42, new int[]{-42,-47});
    rules[69] = new Rule(-43, new int[]{-39});
    rules[70] = new Rule(-39, new int[]{});
    rules[71] = new Rule(-39, new int[]{-39,-46});
    rules[72] = new Rule(-48, new int[]{-29});
    rules[73] = new Rule(-48, new int[]{-52});
    rules[74] = new Rule(-48, new int[]{-285});
    rules[75] = new Rule(-48, new int[]{-306});
    rules[76] = new Rule(-48, new int[]{-228});
    rules[77] = new Rule(-48, new int[]{-227});
    rules[78] = new Rule(-47, new int[]{-164});
    rules[79] = new Rule(-47, new int[]{-29});
    rules[80] = new Rule(-47, new int[]{-52});
    rules[81] = new Rule(-47, new int[]{-285});
    rules[82] = new Rule(-47, new int[]{-306});
    rules[83] = new Rule(-47, new int[]{-216});
    rules[84] = new Rule(-209, new int[]{-210});
    rules[85] = new Rule(-209, new int[]{-213});
    rules[86] = new Rule(-216, new int[]{-6,-209});
    rules[87] = new Rule(-46, new int[]{-164});
    rules[88] = new Rule(-46, new int[]{-29});
    rules[89] = new Rule(-46, new int[]{-52});
    rules[90] = new Rule(-46, new int[]{-285});
    rules[91] = new Rule(-46, new int[]{-306});
    rules[92] = new Rule(-228, new int[]{-6,-221});
    rules[93] = new Rule(-228, new int[]{-6,-221,146,10});
    rules[94] = new Rule(-227, new int[]{-6,-225});
    rules[95] = new Rule(-227, new int[]{-6,-225,146,10});
    rules[96] = new Rule(-164, new int[]{57,-152,10});
    rules[97] = new Rule(-152, new int[]{-139});
    rules[98] = new Rule(-152, new int[]{-152,98,-139});
    rules[99] = new Rule(-139, new int[]{152});
    rules[100] = new Rule(-139, new int[]{-143});
    rules[101] = new Rule(-29, new int[]{27,-27});
    rules[102] = new Rule(-29, new int[]{-29,-27});
    rules[103] = new Rule(-52, new int[]{65,-27});
    rules[104] = new Rule(-52, new int[]{-52,-27});
    rules[105] = new Rule(-285, new int[]{48,-49});
    rules[106] = new Rule(-285, new int[]{-285,-49});
    rules[107] = new Rule(-310, new int[]{-307});
    rules[108] = new Rule(-310, new int[]{8,-143,98,-154,9,108,-98,10});
    rules[109] = new Rule(-306, new int[]{51,-310});
    rules[110] = new Rule(-306, new int[]{60,-310});
    rules[111] = new Rule(-306, new int[]{-306,-310});
    rules[112] = new Rule(-27, new int[]{-28,10});
    rules[113] = new Rule(-28, new int[]{-137,118,-106});
    rules[114] = new Rule(-28, new int[]{-137,5,-272,118,-82});
    rules[115] = new Rule(-106, new int[]{-87});
    rules[116] = new Rule(-106, new int[]{-92});
    rules[117] = new Rule(-137, new int[]{-143});
    rules[118] = new Rule(-88, new int[]{-79});
    rules[119] = new Rule(-88, new int[]{-88,-188,-79});
    rules[120] = new Rule(-87, new int[]{-88});
    rules[121] = new Rule(-87, new int[]{-237});
    rules[122] = new Rule(-87, new int[]{-87,16,-88});
    rules[123] = new Rule(-237, new int[]{-87,13,-87,5,-87});
    rules[124] = new Rule(-188, new int[]{118});
    rules[125] = new Rule(-188, new int[]{123});
    rules[126] = new Rule(-188, new int[]{121});
    rules[127] = new Rule(-188, new int[]{119});
    rules[128] = new Rule(-188, new int[]{122});
    rules[129] = new Rule(-188, new int[]{120});
    rules[130] = new Rule(-188, new int[]{135});
    rules[131] = new Rule(-79, new int[]{-13});
    rules[132] = new Rule(-79, new int[]{-79,-189,-13});
    rules[133] = new Rule(-189, new int[]{114});
    rules[134] = new Rule(-189, new int[]{113});
    rules[135] = new Rule(-189, new int[]{126});
    rules[136] = new Rule(-189, new int[]{127});
    rules[137] = new Rule(-261, new int[]{-13,-197,-280});
    rules[138] = new Rule(-265, new int[]{-11,117,-10});
    rules[139] = new Rule(-265, new int[]{-11,117,-265});
    rules[140] = new Rule(-265, new int[]{-195,-265});
    rules[141] = new Rule(-13, new int[]{-10});
    rules[142] = new Rule(-13, new int[]{-261});
    rules[143] = new Rule(-13, new int[]{-265});
    rules[144] = new Rule(-13, new int[]{-13,-191,-10});
    rules[145] = new Rule(-13, new int[]{-13,-191,-265});
    rules[146] = new Rule(-191, new int[]{116});
    rules[147] = new Rule(-191, new int[]{115});
    rules[148] = new Rule(-191, new int[]{129});
    rules[149] = new Rule(-191, new int[]{130});
    rules[150] = new Rule(-191, new int[]{131});
    rules[151] = new Rule(-191, new int[]{132});
    rules[152] = new Rule(-191, new int[]{128});
    rules[153] = new Rule(-11, new int[]{-14});
    rules[154] = new Rule(-11, new int[]{8,-87,9});
    rules[155] = new Rule(-10, new int[]{-14});
    rules[156] = new Rule(-10, new int[]{-235});
    rules[157] = new Rule(-10, new int[]{54});
    rules[158] = new Rule(-10, new int[]{139,-10});
    rules[159] = new Rule(-10, new int[]{8,-87,9});
    rules[160] = new Rule(-10, new int[]{133,-10});
    rules[161] = new Rule(-10, new int[]{-195,-10});
    rules[162] = new Rule(-10, new int[]{-169});
    rules[163] = new Rule(-10, new int[]{-57});
    rules[164] = new Rule(-235, new int[]{11,-68,12});
    rules[165] = new Rule(-235, new int[]{75,-68,75});
    rules[166] = new Rule(-195, new int[]{114});
    rules[167] = new Rule(-195, new int[]{113});
    rules[168] = new Rule(-14, new int[]{-143});
    rules[169] = new Rule(-14, new int[]{-161});
    rules[170] = new Rule(-14, new int[]{-16});
    rules[171] = new Rule(-14, new int[]{40,-143});
    rules[172] = new Rule(-14, new int[]{-253});
    rules[173] = new Rule(-14, new int[]{-291});
    rules[174] = new Rule(-14, new int[]{-14,-12});
    rules[175] = new Rule(-14, new int[]{-14,4,-295});
    rules[176] = new Rule(-14, new int[]{-14,11,-117,12});
    rules[177] = new Rule(-12, new int[]{7,-134});
    rules[178] = new Rule(-12, new int[]{140});
    rules[179] = new Rule(-12, new int[]{8,-74,9});
    rules[180] = new Rule(-12, new int[]{11,-73,12});
    rules[181] = new Rule(-74, new int[]{-70});
    rules[182] = new Rule(-74, new int[]{});
    rules[183] = new Rule(-73, new int[]{-71});
    rules[184] = new Rule(-73, new int[]{});
    rules[185] = new Rule(-71, new int[]{-91});
    rules[186] = new Rule(-71, new int[]{-71,98,-91});
    rules[187] = new Rule(-91, new int[]{-87});
    rules[188] = new Rule(-91, new int[]{-87,6,-87});
    rules[189] = new Rule(-16, new int[]{152});
    rules[190] = new Rule(-16, new int[]{155});
    rules[191] = new Rule(-16, new int[]{154});
    rules[192] = new Rule(-16, new int[]{153});
    rules[193] = new Rule(-82, new int[]{-87});
    rules[194] = new Rule(-82, new int[]{-92});
    rules[195] = new Rule(-82, new int[]{-239});
    rules[196] = new Rule(-92, new int[]{8,-66,9});
    rules[197] = new Rule(-66, new int[]{});
    rules[198] = new Rule(-66, new int[]{-65});
    rules[199] = new Rule(-65, new int[]{-83});
    rules[200] = new Rule(-65, new int[]{-65,98,-83});
    rules[201] = new Rule(-239, new int[]{8,-241,9});
    rules[202] = new Rule(-241, new int[]{-240});
    rules[203] = new Rule(-241, new int[]{-240,10});
    rules[204] = new Rule(-240, new int[]{-242});
    rules[205] = new Rule(-240, new int[]{-240,10,-242});
    rules[206] = new Rule(-242, new int[]{-132,5,-82});
    rules[207] = new Rule(-132, new int[]{-143});
    rules[208] = new Rule(-49, new int[]{-6,-50});
    rules[209] = new Rule(-6, new int[]{-246});
    rules[210] = new Rule(-6, new int[]{-6,-246});
    rules[211] = new Rule(-6, new int[]{});
    rules[212] = new Rule(-246, new int[]{11,-247,12});
    rules[213] = new Rule(-247, new int[]{-8});
    rules[214] = new Rule(-247, new int[]{-247,98,-8});
    rules[215] = new Rule(-8, new int[]{-9});
    rules[216] = new Rule(-8, new int[]{-143,5,-9});
    rules[217] = new Rule(-50, new int[]{-140,118,-283,10});
    rules[218] = new Rule(-50, new int[]{-141,-283,10});
    rules[219] = new Rule(-140, new int[]{-143});
    rules[220] = new Rule(-140, new int[]{-143,-151});
    rules[221] = new Rule(-141, new int[]{-143,121,-154,120});
    rules[222] = new Rule(-283, new int[]{-272});
    rules[223] = new Rule(-283, new int[]{-30});
    rules[224] = new Rule(-269, new int[]{-268,13});
    rules[225] = new Rule(-269, new int[]{-297,13});
    rules[226] = new Rule(-272, new int[]{-268});
    rules[227] = new Rule(-272, new int[]{-269});
    rules[228] = new Rule(-272, new int[]{-252});
    rules[229] = new Rule(-272, new int[]{-245});
    rules[230] = new Rule(-272, new int[]{-277});
    rules[231] = new Rule(-272, new int[]{-222});
    rules[232] = new Rule(-272, new int[]{-297});
    rules[233] = new Rule(-297, new int[]{-176,-295});
    rules[234] = new Rule(-295, new int[]{121,-293,119});
    rules[235] = new Rule(-296, new int[]{123});
    rules[236] = new Rule(-296, new int[]{121,-294,119});
    rules[237] = new Rule(-293, new int[]{-275});
    rules[238] = new Rule(-293, new int[]{-293,98,-275});
    rules[239] = new Rule(-294, new int[]{-276});
    rules[240] = new Rule(-294, new int[]{-294,98,-276});
    rules[241] = new Rule(-276, new int[]{});
    rules[242] = new Rule(-275, new int[]{-268});
    rules[243] = new Rule(-275, new int[]{-268,13});
    rules[244] = new Rule(-275, new int[]{-277});
    rules[245] = new Rule(-275, new int[]{-222});
    rules[246] = new Rule(-275, new int[]{-297});
    rules[247] = new Rule(-268, new int[]{-90});
    rules[248] = new Rule(-268, new int[]{-90,6,-90});
    rules[249] = new Rule(-268, new int[]{8,-78,9});
    rules[250] = new Rule(-90, new int[]{-103});
    rules[251] = new Rule(-90, new int[]{-90,-189,-103});
    rules[252] = new Rule(-103, new int[]{-104});
    rules[253] = new Rule(-103, new int[]{-103,-191,-104});
    rules[254] = new Rule(-104, new int[]{-176});
    rules[255] = new Rule(-104, new int[]{-16});
    rules[256] = new Rule(-104, new int[]{-195,-104});
    rules[257] = new Rule(-104, new int[]{-161});
    rules[258] = new Rule(-104, new int[]{-104,8,-73,9});
    rules[259] = new Rule(-176, new int[]{-143});
    rules[260] = new Rule(-176, new int[]{-176,7,-134});
    rules[261] = new Rule(-78, new int[]{-76,98,-76});
    rules[262] = new Rule(-78, new int[]{-78,98,-76});
    rules[263] = new Rule(-76, new int[]{-272});
    rules[264] = new Rule(-76, new int[]{-272,118,-85});
    rules[265] = new Rule(-245, new int[]{140,-271});
    rules[266] = new Rule(-277, new int[]{-278});
    rules[267] = new Rule(-277, new int[]{63,-278});
    rules[268] = new Rule(-278, new int[]{-274});
    rules[269] = new Rule(-278, new int[]{-31});
    rules[270] = new Rule(-278, new int[]{-259});
    rules[271] = new Rule(-278, new int[]{-126});
    rules[272] = new Rule(-278, new int[]{-127});
    rules[273] = new Rule(-127, new int[]{72,56,-272});
    rules[274] = new Rule(-274, new int[]{22,11,-160,12,56,-272});
    rules[275] = new Rule(-274, new int[]{-266});
    rules[276] = new Rule(-266, new int[]{22,56,-272});
    rules[277] = new Rule(-160, new int[]{-267});
    rules[278] = new Rule(-160, new int[]{-160,98,-267});
    rules[279] = new Rule(-267, new int[]{-268});
    rules[280] = new Rule(-267, new int[]{});
    rules[281] = new Rule(-259, new int[]{47,56,-272});
    rules[282] = new Rule(-126, new int[]{32,56,-272});
    rules[283] = new Rule(-126, new int[]{32});
    rules[284] = new Rule(-252, new int[]{141,11,-87,12});
    rules[285] = new Rule(-222, new int[]{-220});
    rules[286] = new Rule(-220, new int[]{-219});
    rules[287] = new Rule(-219, new int[]{42,-124});
    rules[288] = new Rule(-219, new int[]{35,-124,5,-271});
    rules[289] = new Rule(-219, new int[]{-176,125,-275});
    rules[290] = new Rule(-219, new int[]{-297,125,-275});
    rules[291] = new Rule(-219, new int[]{8,9,125,-275});
    rules[292] = new Rule(-219, new int[]{8,-78,9,125,-275});
    rules[293] = new Rule(-219, new int[]{-176,125,8,9});
    rules[294] = new Rule(-219, new int[]{-297,125,8,9});
    rules[295] = new Rule(-219, new int[]{8,9,125,8,9});
    rules[296] = new Rule(-219, new int[]{8,-78,9,125,8,9});
    rules[297] = new Rule(-30, new int[]{-21,-287,-179,-314,-26});
    rules[298] = new Rule(-31, new int[]{46,-179,-314,-25,90});
    rules[299] = new Rule(-20, new int[]{67});
    rules[300] = new Rule(-20, new int[]{68});
    rules[301] = new Rule(-20, new int[]{145});
    rules[302] = new Rule(-20, new int[]{25});
    rules[303] = new Rule(-20, new int[]{26});
    rules[304] = new Rule(-21, new int[]{});
    rules[305] = new Rule(-21, new int[]{-22});
    rules[306] = new Rule(-22, new int[]{-20});
    rules[307] = new Rule(-22, new int[]{-22,-20});
    rules[308] = new Rule(-287, new int[]{24});
    rules[309] = new Rule(-287, new int[]{41});
    rules[310] = new Rule(-287, new int[]{62});
    rules[311] = new Rule(-287, new int[]{62,24});
    rules[312] = new Rule(-287, new int[]{62,46});
    rules[313] = new Rule(-287, new int[]{62,41});
    rules[314] = new Rule(-26, new int[]{});
    rules[315] = new Rule(-26, new int[]{-25,90});
    rules[316] = new Rule(-179, new int[]{});
    rules[317] = new Rule(-179, new int[]{8,-178,9});
    rules[318] = new Rule(-178, new int[]{-177});
    rules[319] = new Rule(-178, new int[]{-178,98,-177});
    rules[320] = new Rule(-177, new int[]{-176});
    rules[321] = new Rule(-177, new int[]{-297});
    rules[322] = new Rule(-151, new int[]{121,-154,119});
    rules[323] = new Rule(-314, new int[]{});
    rules[324] = new Rule(-314, new int[]{-313});
    rules[325] = new Rule(-313, new int[]{-312});
    rules[326] = new Rule(-313, new int[]{-313,-312});
    rules[327] = new Rule(-312, new int[]{21,-154,5,-284,10});
    rules[328] = new Rule(-284, new int[]{-281});
    rules[329] = new Rule(-284, new int[]{-284,98,-281});
    rules[330] = new Rule(-281, new int[]{-272});
    rules[331] = new Rule(-281, new int[]{24});
    rules[332] = new Rule(-281, new int[]{46});
    rules[333] = new Rule(-281, new int[]{28});
    rules[334] = new Rule(-25, new int[]{-32});
    rules[335] = new Rule(-25, new int[]{-25,-7,-32});
    rules[336] = new Rule(-7, new int[]{83});
    rules[337] = new Rule(-7, new int[]{82});
    rules[338] = new Rule(-7, new int[]{81});
    rules[339] = new Rule(-7, new int[]{80});
    rules[340] = new Rule(-32, new int[]{});
    rules[341] = new Rule(-32, new int[]{-34,-186});
    rules[342] = new Rule(-32, new int[]{-33});
    rules[343] = new Rule(-32, new int[]{-34,10,-33});
    rules[344] = new Rule(-154, new int[]{-143});
    rules[345] = new Rule(-154, new int[]{-154,98,-143});
    rules[346] = new Rule(-186, new int[]{});
    rules[347] = new Rule(-186, new int[]{10});
    rules[348] = new Rule(-34, new int[]{-45});
    rules[349] = new Rule(-34, new int[]{-34,10,-45});
    rules[350] = new Rule(-45, new int[]{-6,-51});
    rules[351] = new Rule(-33, new int[]{-54});
    rules[352] = new Rule(-33, new int[]{-33,-54});
    rules[353] = new Rule(-54, new int[]{-53});
    rules[354] = new Rule(-54, new int[]{-55});
    rules[355] = new Rule(-51, new int[]{27,-28});
    rules[356] = new Rule(-51, new int[]{-309});
    rules[357] = new Rule(-51, new int[]{-3,-309});
    rules[358] = new Rule(-3, new int[]{26});
    rules[359] = new Rule(-3, new int[]{24});
    rules[360] = new Rule(-309, new int[]{-308});
    rules[361] = new Rule(-309, new int[]{60,-154,5,-272});
    rules[362] = new Rule(-53, new int[]{-6,-218});
    rules[363] = new Rule(-53, new int[]{-6,-215});
    rules[364] = new Rule(-215, new int[]{-211});
    rules[365] = new Rule(-215, new int[]{-214});
    rules[366] = new Rule(-218, new int[]{-3,-226});
    rules[367] = new Rule(-218, new int[]{-226});
    rules[368] = new Rule(-218, new int[]{-223});
    rules[369] = new Rule(-226, new int[]{-224});
    rules[370] = new Rule(-224, new int[]{-221});
    rules[371] = new Rule(-224, new int[]{-225});
    rules[372] = new Rule(-223, new int[]{28,-168,-124,-203});
    rules[373] = new Rule(-223, new int[]{-3,28,-168,-124,-203});
    rules[374] = new Rule(-223, new int[]{29,-168,-124,-203});
    rules[375] = new Rule(-168, new int[]{-167});
    rules[376] = new Rule(-168, new int[]{});
    rules[377] = new Rule(-55, new int[]{-6,-254});
    rules[378] = new Rule(-254, new int[]{44,-166,-229,-198,10,-201});
    rules[379] = new Rule(-254, new int[]{44,-166,-229,-198,10,-206,10,-201});
    rules[380] = new Rule(-254, new int[]{-3,44,-166,-229,-198,10,-201});
    rules[381] = new Rule(-254, new int[]{-3,44,-166,-229,-198,10,-206,10,-201});
    rules[382] = new Rule(-254, new int[]{25,44,-166,-229,-207,10});
    rules[383] = new Rule(-254, new int[]{-3,25,44,-166,-229,-207,10});
    rules[384] = new Rule(-207, new int[]{108,-85});
    rules[385] = new Rule(-207, new int[]{});
    rules[386] = new Rule(-201, new int[]{});
    rules[387] = new Rule(-201, new int[]{61,10});
    rules[388] = new Rule(-229, new int[]{-234,5,-271});
    rules[389] = new Rule(-234, new int[]{});
    rules[390] = new Rule(-234, new int[]{11,-233,12});
    rules[391] = new Rule(-233, new int[]{-232});
    rules[392] = new Rule(-233, new int[]{-233,10,-232});
    rules[393] = new Rule(-232, new int[]{-154,5,-271});
    rules[394] = new Rule(-110, new int[]{-86});
    rules[395] = new Rule(-110, new int[]{});
    rules[396] = new Rule(-198, new int[]{});
    rules[397] = new Rule(-198, new int[]{84,-110,-199});
    rules[398] = new Rule(-198, new int[]{85,-256,-200});
    rules[399] = new Rule(-199, new int[]{});
    rules[400] = new Rule(-199, new int[]{85,-256});
    rules[401] = new Rule(-200, new int[]{});
    rules[402] = new Rule(-200, new int[]{84,-110});
    rules[403] = new Rule(-307, new int[]{-308,10});
    rules[404] = new Rule(-335, new int[]{108});
    rules[405] = new Rule(-335, new int[]{118});
    rules[406] = new Rule(-308, new int[]{-154,5,-272});
    rules[407] = new Rule(-308, new int[]{-154,108,-86});
    rules[408] = new Rule(-308, new int[]{-154,5,-272,-335,-84});
    rules[409] = new Rule(-84, new int[]{-83});
    rules[410] = new Rule(-84, new int[]{-79,6,-13});
    rules[411] = new Rule(-84, new int[]{-320});
    rules[412] = new Rule(-84, new int[]{-143,125,-325});
    rules[413] = new Rule(-84, new int[]{8,9,-321,125,-325});
    rules[414] = new Rule(-84, new int[]{8,-66,9,125,-325});
    rules[415] = new Rule(-83, new int[]{-82});
    rules[416] = new Rule(-213, new int[]{-223,-173});
    rules[417] = new Rule(-213, new int[]{28,-168,-124,108,-256,10});
    rules[418] = new Rule(-213, new int[]{-3,28,-168,-124,108,-256,10});
    rules[419] = new Rule(-214, new int[]{-223,-172});
    rules[420] = new Rule(-214, new int[]{28,-168,-124,108,-256,10});
    rules[421] = new Rule(-214, new int[]{-3,28,-168,-124,108,-256,10});
    rules[422] = new Rule(-210, new int[]{-217});
    rules[423] = new Rule(-210, new int[]{-3,-217});
    rules[424] = new Rule(-217, new int[]{-224,-174});
    rules[425] = new Rule(-217, new int[]{35,-166,-124,5,-271,-204,108,-98,10});
    rules[426] = new Rule(-217, new int[]{35,-166,-124,-204,108,-98,10});
    rules[427] = new Rule(-217, new int[]{35,-166,-124,5,-271,-204,108,-319,10});
    rules[428] = new Rule(-217, new int[]{35,-166,-124,-204,108,-319,10});
    rules[429] = new Rule(-217, new int[]{42,-167,-124,-204,108,-256,10});
    rules[430] = new Rule(-217, new int[]{-224,146,10});
    rules[431] = new Rule(-217, new int[]{27,-27});
    rules[432] = new Rule(-211, new int[]{-212});
    rules[433] = new Rule(-211, new int[]{-3,-212});
    rules[434] = new Rule(-212, new int[]{-224,-172});
    rules[435] = new Rule(-212, new int[]{35,-166,-124,5,-271,-204,108,-100,10});
    rules[436] = new Rule(-212, new int[]{35,-166,-124,-204,108,-100,10});
    rules[437] = new Rule(-212, new int[]{42,-167,-124,-204,108,-256,10});
    rules[438] = new Rule(-174, new int[]{-173});
    rules[439] = new Rule(-174, new int[]{-61});
    rules[440] = new Rule(-167, new int[]{-166});
    rules[441] = new Rule(-166, new int[]{-138});
    rules[442] = new Rule(-166, new int[]{-331,7,-138});
    rules[443] = new Rule(-145, new int[]{-133});
    rules[444] = new Rule(-331, new int[]{-145});
    rules[445] = new Rule(-331, new int[]{-331,7,-145});
    rules[446] = new Rule(-138, new int[]{-133});
    rules[447] = new Rule(-138, new int[]{-187});
    rules[448] = new Rule(-138, new int[]{-187,-151});
    rules[449] = new Rule(-133, new int[]{-130});
    rules[450] = new Rule(-133, new int[]{-130,-151});
    rules[451] = new Rule(-130, new int[]{-143});
    rules[452] = new Rule(-221, new int[]{42,-167,-124,-203,-314});
    rules[453] = new Rule(-225, new int[]{35,-166,-124,-203,-314});
    rules[454] = new Rule(-225, new int[]{35,-166,-124,5,-271,-203,-314});
    rules[455] = new Rule(-61, new int[]{105,-105,79,-105,10});
    rules[456] = new Rule(-61, new int[]{105,-105,10});
    rules[457] = new Rule(-61, new int[]{105,10});
    rules[458] = new Rule(-105, new int[]{-143});
    rules[459] = new Rule(-105, new int[]{-161});
    rules[460] = new Rule(-173, new int[]{-41,-251,10});
    rules[461] = new Rule(-172, new int[]{-43,-251,10});
    rules[462] = new Rule(-172, new int[]{-61});
    rules[463] = new Rule(-124, new int[]{});
    rules[464] = new Rule(-124, new int[]{8,9});
    rules[465] = new Rule(-124, new int[]{8,-125,9});
    rules[466] = new Rule(-125, new int[]{-56});
    rules[467] = new Rule(-125, new int[]{-125,10,-56});
    rules[468] = new Rule(-56, new int[]{-6,-292});
    rules[469] = new Rule(-292, new int[]{-155,5,-271});
    rules[470] = new Rule(-292, new int[]{51,-155,5,-271});
    rules[471] = new Rule(-292, new int[]{27,-155,5,-271});
    rules[472] = new Rule(-292, new int[]{106,-155,5,-271});
    rules[473] = new Rule(-292, new int[]{-155,5,-271,108,-85});
    rules[474] = new Rule(-292, new int[]{51,-155,5,-271,108,-85});
    rules[475] = new Rule(-292, new int[]{27,-155,5,-271,108,-85});
    rules[476] = new Rule(-155, new int[]{-131});
    rules[477] = new Rule(-155, new int[]{-155,98,-131});
    rules[478] = new Rule(-131, new int[]{-143});
    rules[479] = new Rule(-271, new int[]{-272});
    rules[480] = new Rule(-273, new int[]{-268});
    rules[481] = new Rule(-273, new int[]{-252});
    rules[482] = new Rule(-273, new int[]{-245});
    rules[483] = new Rule(-273, new int[]{-277});
    rules[484] = new Rule(-273, new int[]{-297});
    rules[485] = new Rule(-257, new int[]{-256});
    rules[486] = new Rule(-257, new int[]{-139,5,-257});
    rules[487] = new Rule(-256, new int[]{});
    rules[488] = new Rule(-256, new int[]{-4});
    rules[489] = new Rule(-256, new int[]{-208});
    rules[490] = new Rule(-256, new int[]{-129});
    rules[491] = new Rule(-256, new int[]{-251});
    rules[492] = new Rule(-256, new int[]{-149});
    rules[493] = new Rule(-256, new int[]{-35});
    rules[494] = new Rule(-256, new int[]{-243});
    rules[495] = new Rule(-256, new int[]{-315});
    rules[496] = new Rule(-256, new int[]{-120});
    rules[497] = new Rule(-256, new int[]{-316});
    rules[498] = new Rule(-256, new int[]{-156});
    rules[499] = new Rule(-256, new int[]{-298});
    rules[500] = new Rule(-256, new int[]{-244});
    rules[501] = new Rule(-256, new int[]{-119});
    rules[502] = new Rule(-256, new int[]{-311});
    rules[503] = new Rule(-256, new int[]{-59});
    rules[504] = new Rule(-256, new int[]{-165});
    rules[505] = new Rule(-256, new int[]{-122});
    rules[506] = new Rule(-256, new int[]{-123});
    rules[507] = new Rule(-256, new int[]{-121});
    rules[508] = new Rule(-256, new int[]{-345});
    rules[509] = new Rule(-121, new int[]{71,-98,97,-256});
    rules[510] = new Rule(-122, new int[]{73,-100});
    rules[511] = new Rule(-123, new int[]{73,72,-100});
    rules[512] = new Rule(-311, new int[]{51,-308});
    rules[513] = new Rule(-311, new int[]{8,51,-143,98,-334,9,108,-85});
    rules[514] = new Rule(-311, new int[]{51,8,-143,98,-154,9,108,-85});
    rules[515] = new Rule(-4, new int[]{-109,-190,-86});
    rules[516] = new Rule(-4, new int[]{8,-108,98,-333,9,-190,-85});
    rules[517] = new Rule(-4, new int[]{-108,17,-116,12,-190,-85});
    rules[518] = new Rule(-333, new int[]{-108});
    rules[519] = new Rule(-333, new int[]{-333,98,-108});
    rules[520] = new Rule(-334, new int[]{51,-143});
    rules[521] = new Rule(-334, new int[]{-334,98,51,-143});
    rules[522] = new Rule(-208, new int[]{-109});
    rules[523] = new Rule(-129, new int[]{55,-139});
    rules[524] = new Rule(-251, new int[]{89,-248,90});
    rules[525] = new Rule(-248, new int[]{-257});
    rules[526] = new Rule(-248, new int[]{-248,10,-257});
    rules[527] = new Rule(-149, new int[]{38,-98,49,-256});
    rules[528] = new Rule(-149, new int[]{38,-98,49,-256,30,-256});
    rules[529] = new Rule(-345, new int[]{36,-98,53,-347,-249,90});
    rules[530] = new Rule(-345, new int[]{36,-98,53,-347,10,-249,90});
    rules[531] = new Rule(-347, new int[]{-346});
    rules[532] = new Rule(-347, new int[]{-347,10,-346});
    rules[533] = new Rule(-346, new int[]{-339,37,-98,5,-256});
    rules[534] = new Rule(-346, new int[]{-338,5,-256});
    rules[535] = new Rule(-346, new int[]{-340,5,-256});
    rules[536] = new Rule(-346, new int[]{-341,37,-98,5,-256});
    rules[537] = new Rule(-346, new int[]{-341,5,-256});
    rules[538] = new Rule(-35, new int[]{23,-98,56,-36,-249,90});
    rules[539] = new Rule(-35, new int[]{23,-98,56,-36,10,-249,90});
    rules[540] = new Rule(-35, new int[]{23,-98,56,-249,90});
    rules[541] = new Rule(-36, new int[]{-258});
    rules[542] = new Rule(-36, new int[]{-36,10,-258});
    rules[543] = new Rule(-258, new int[]{-72,5,-256});
    rules[544] = new Rule(-72, new int[]{-107});
    rules[545] = new Rule(-72, new int[]{-72,98,-107});
    rules[546] = new Rule(-107, new int[]{-91});
    rules[547] = new Rule(-249, new int[]{});
    rules[548] = new Rule(-249, new int[]{30,-248});
    rules[549] = new Rule(-243, new int[]{95,-248,96,-85});
    rules[550] = new Rule(-315, new int[]{52,-98,-288,-256});
    rules[551] = new Rule(-288, new int[]{97});
    rules[552] = new Rule(-288, new int[]{});
    rules[553] = new Rule(-165, new int[]{58,-98,97,-256});
    rules[554] = new Rule(-119, new int[]{34,-143,-270,135,-98,97,-256});
    rules[555] = new Rule(-119, new int[]{34,51,-143,5,-272,135,-98,97,-256});
    rules[556] = new Rule(-119, new int[]{34,51,-143,135,-98,97,-256});
    rules[557] = new Rule(-119, new int[]{34,51,8,-154,9,135,-98,97,-256});
    rules[558] = new Rule(-270, new int[]{5,-272});
    rules[559] = new Rule(-270, new int[]{});
    rules[560] = new Rule(-120, new int[]{33,-19,-143,-282,-98,-115,-98,-288,-256});
    rules[561] = new Rule(-19, new int[]{51});
    rules[562] = new Rule(-19, new int[]{});
    rules[563] = new Rule(-282, new int[]{108});
    rules[564] = new Rule(-282, new int[]{5,-176,108});
    rules[565] = new Rule(-115, new int[]{69});
    rules[566] = new Rule(-115, new int[]{70});
    rules[567] = new Rule(-316, new int[]{53,-70,97,-256});
    rules[568] = new Rule(-156, new int[]{40});
    rules[569] = new Rule(-298, new int[]{100,-248,-286});
    rules[570] = new Rule(-286, new int[]{99,-248,90});
    rules[571] = new Rule(-286, new int[]{31,-60,90});
    rules[572] = new Rule(-60, new int[]{-63,-250});
    rules[573] = new Rule(-60, new int[]{-63,10,-250});
    rules[574] = new Rule(-60, new int[]{-248});
    rules[575] = new Rule(-63, new int[]{-62});
    rules[576] = new Rule(-63, new int[]{-63,10,-62});
    rules[577] = new Rule(-250, new int[]{});
    rules[578] = new Rule(-250, new int[]{30,-248});
    rules[579] = new Rule(-62, new int[]{78,-64,97,-256});
    rules[580] = new Rule(-64, new int[]{-175});
    rules[581] = new Rule(-64, new int[]{-136,5,-175});
    rules[582] = new Rule(-175, new int[]{-176});
    rules[583] = new Rule(-136, new int[]{-143});
    rules[584] = new Rule(-244, new int[]{45});
    rules[585] = new Rule(-244, new int[]{45,-85});
    rules[586] = new Rule(-70, new int[]{-86});
    rules[587] = new Rule(-70, new int[]{-70,98,-86});
    rules[588] = new Rule(-59, new int[]{-170});
    rules[589] = new Rule(-170, new int[]{-169});
    rules[590] = new Rule(-86, new int[]{-85});
    rules[591] = new Rule(-86, new int[]{-319});
    rules[592] = new Rule(-86, new int[]{40});
    rules[593] = new Rule(-85, new int[]{-98});
    rules[594] = new Rule(-85, new int[]{-116});
    rules[595] = new Rule(-98, new int[]{-96});
    rules[596] = new Rule(-98, new int[]{-236});
    rules[597] = new Rule(-98, new int[]{-238});
    rules[598] = new Rule(-113, new int[]{-96});
    rules[599] = new Rule(-113, new int[]{-236});
    rules[600] = new Rule(-114, new int[]{-96});
    rules[601] = new Rule(-114, new int[]{-238});
    rules[602] = new Rule(-100, new int[]{-98});
    rules[603] = new Rule(-100, new int[]{-319});
    rules[604] = new Rule(-101, new int[]{-96});
    rules[605] = new Rule(-101, new int[]{-236});
    rules[606] = new Rule(-101, new int[]{-319});
    rules[607] = new Rule(-96, new int[]{-95});
    rules[608] = new Rule(-96, new int[]{-96,16,-95});
    rules[609] = new Rule(-253, new int[]{19,8,-280,9});
    rules[610] = new Rule(-291, new int[]{20,8,-280,9});
    rules[611] = new Rule(-291, new int[]{20,8,-279,9});
    rules[612] = new Rule(-236, new int[]{-113,13,-113,5,-113});
    rules[613] = new Rule(-238, new int[]{38,-114,49,-114,30,-114});
    rules[614] = new Rule(-279, new int[]{-176,-296});
    rules[615] = new Rule(-279, new int[]{-176,4,-296});
    rules[616] = new Rule(-280, new int[]{-176});
    rules[617] = new Rule(-280, new int[]{-176,-295});
    rules[618] = new Rule(-280, new int[]{-176,4,-295});
    rules[619] = new Rule(-5, new int[]{8,-66,9});
    rules[620] = new Rule(-5, new int[]{});
    rules[621] = new Rule(-169, new int[]{77,-280,-69});
    rules[622] = new Rule(-169, new int[]{77,-280,11,-67,12,-5});
    rules[623] = new Rule(-169, new int[]{77,24,8,-330,9});
    rules[624] = new Rule(-329, new int[]{-143,108,-95});
    rules[625] = new Rule(-329, new int[]{-95});
    rules[626] = new Rule(-330, new int[]{-329});
    rules[627] = new Rule(-330, new int[]{-330,98,-329});
    rules[628] = new Rule(-69, new int[]{});
    rules[629] = new Rule(-69, new int[]{8,-67,9});
    rules[630] = new Rule(-95, new int[]{-102});
    rules[631] = new Rule(-95, new int[]{-95,-192,-102});
    rules[632] = new Rule(-95, new int[]{-95,-192,-238});
    rules[633] = new Rule(-95, new int[]{-262,8,-350,9});
    rules[634] = new Rule(-337, new int[]{-280,8,-350,9});
    rules[635] = new Rule(-339, new int[]{-280,8,-351,9});
    rules[636] = new Rule(-338, new int[]{-280,8,-351,9});
    rules[637] = new Rule(-338, new int[]{-354});
    rules[638] = new Rule(-354, new int[]{-336});
    rules[639] = new Rule(-354, new int[]{-354,98,-336});
    rules[640] = new Rule(-336, new int[]{-15});
    rules[641] = new Rule(-336, new int[]{-280});
    rules[642] = new Rule(-336, new int[]{54});
    rules[643] = new Rule(-336, new int[]{-253});
    rules[644] = new Rule(-336, new int[]{-291});
    rules[645] = new Rule(-340, new int[]{11,-352,12});
    rules[646] = new Rule(-352, new int[]{-342});
    rules[647] = new Rule(-352, new int[]{-352,98,-342});
    rules[648] = new Rule(-342, new int[]{-15});
    rules[649] = new Rule(-342, new int[]{-344});
    rules[650] = new Rule(-342, new int[]{14});
    rules[651] = new Rule(-342, new int[]{-339});
    rules[652] = new Rule(-342, new int[]{-340});
    rules[653] = new Rule(-342, new int[]{-341});
    rules[654] = new Rule(-342, new int[]{6});
    rules[655] = new Rule(-344, new int[]{51,-143});
    rules[656] = new Rule(-341, new int[]{8,-353,9});
    rules[657] = new Rule(-343, new int[]{14});
    rules[658] = new Rule(-343, new int[]{-15});
    rules[659] = new Rule(-343, new int[]{-195,-15});
    rules[660] = new Rule(-343, new int[]{51,-143});
    rules[661] = new Rule(-343, new int[]{-339});
    rules[662] = new Rule(-343, new int[]{-340});
    rules[663] = new Rule(-343, new int[]{-341});
    rules[664] = new Rule(-353, new int[]{-343});
    rules[665] = new Rule(-353, new int[]{-353,98,-343});
    rules[666] = new Rule(-351, new int[]{-349});
    rules[667] = new Rule(-351, new int[]{-351,10,-349});
    rules[668] = new Rule(-351, new int[]{-351,98,-349});
    rules[669] = new Rule(-350, new int[]{-348});
    rules[670] = new Rule(-350, new int[]{-350,10,-348});
    rules[671] = new Rule(-350, new int[]{-350,98,-348});
    rules[672] = new Rule(-348, new int[]{14});
    rules[673] = new Rule(-348, new int[]{-15});
    rules[674] = new Rule(-348, new int[]{51,-143,5,-272});
    rules[675] = new Rule(-348, new int[]{51,-143});
    rules[676] = new Rule(-348, new int[]{-337});
    rules[677] = new Rule(-348, new int[]{-340});
    rules[678] = new Rule(-348, new int[]{-341});
    rules[679] = new Rule(-349, new int[]{14});
    rules[680] = new Rule(-349, new int[]{-15});
    rules[681] = new Rule(-349, new int[]{-195,-15});
    rules[682] = new Rule(-349, new int[]{-143,5,-272});
    rules[683] = new Rule(-349, new int[]{-143});
    rules[684] = new Rule(-349, new int[]{51,-143,5,-272});
    rules[685] = new Rule(-349, new int[]{51,-143});
    rules[686] = new Rule(-349, new int[]{-339});
    rules[687] = new Rule(-349, new int[]{-340});
    rules[688] = new Rule(-349, new int[]{-341});
    rules[689] = new Rule(-111, new int[]{-102});
    rules[690] = new Rule(-111, new int[]{});
    rules[691] = new Rule(-118, new int[]{-87});
    rules[692] = new Rule(-118, new int[]{});
    rules[693] = new Rule(-116, new int[]{-102,5,-111});
    rules[694] = new Rule(-116, new int[]{5,-111});
    rules[695] = new Rule(-116, new int[]{-102,5,-111,5,-102});
    rules[696] = new Rule(-116, new int[]{5,-111,5,-102});
    rules[697] = new Rule(-117, new int[]{-87,5,-118});
    rules[698] = new Rule(-117, new int[]{5,-118});
    rules[699] = new Rule(-117, new int[]{-87,5,-118,5,-87});
    rules[700] = new Rule(-117, new int[]{5,-118,5,-87});
    rules[701] = new Rule(-192, new int[]{118});
    rules[702] = new Rule(-192, new int[]{123});
    rules[703] = new Rule(-192, new int[]{121});
    rules[704] = new Rule(-192, new int[]{119});
    rules[705] = new Rule(-192, new int[]{122});
    rules[706] = new Rule(-192, new int[]{120});
    rules[707] = new Rule(-192, new int[]{135});
    rules[708] = new Rule(-102, new int[]{-81});
    rules[709] = new Rule(-102, new int[]{-102,6,-81});
    rules[710] = new Rule(-81, new int[]{-80});
    rules[711] = new Rule(-81, new int[]{-81,-193,-80});
    rules[712] = new Rule(-81, new int[]{-81,-193,-238});
    rules[713] = new Rule(-193, new int[]{114});
    rules[714] = new Rule(-193, new int[]{113});
    rules[715] = new Rule(-193, new int[]{126});
    rules[716] = new Rule(-193, new int[]{127});
    rules[717] = new Rule(-193, new int[]{124});
    rules[718] = new Rule(-197, new int[]{134});
    rules[719] = new Rule(-197, new int[]{136});
    rules[720] = new Rule(-260, new int[]{-262});
    rules[721] = new Rule(-260, new int[]{-263});
    rules[722] = new Rule(-263, new int[]{-80,134,-280});
    rules[723] = new Rule(-263, new int[]{-80,134,-274});
    rules[724] = new Rule(-262, new int[]{-80,136,-280});
    rules[725] = new Rule(-262, new int[]{-80,136,-274});
    rules[726] = new Rule(-264, new int[]{-94,117,-93});
    rules[727] = new Rule(-264, new int[]{-94,117,-264});
    rules[728] = new Rule(-264, new int[]{-195,-264});
    rules[729] = new Rule(-80, new int[]{-93});
    rules[730] = new Rule(-80, new int[]{-169});
    rules[731] = new Rule(-80, new int[]{-264});
    rules[732] = new Rule(-80, new int[]{-80,-194,-93});
    rules[733] = new Rule(-80, new int[]{-80,-194,-264});
    rules[734] = new Rule(-80, new int[]{-80,-194,-238});
    rules[735] = new Rule(-80, new int[]{-260});
    rules[736] = new Rule(-194, new int[]{116});
    rules[737] = new Rule(-194, new int[]{115});
    rules[738] = new Rule(-194, new int[]{129});
    rules[739] = new Rule(-194, new int[]{130});
    rules[740] = new Rule(-194, new int[]{131});
    rules[741] = new Rule(-194, new int[]{132});
    rules[742] = new Rule(-194, new int[]{128});
    rules[743] = new Rule(-57, new int[]{61,8,-280,9});
    rules[744] = new Rule(-58, new int[]{8,-99,98,-77,-321,-328,9});
    rules[745] = new Rule(-94, new int[]{-15});
    rules[746] = new Rule(-94, new int[]{-109});
    rules[747] = new Rule(-93, new int[]{54});
    rules[748] = new Rule(-93, new int[]{-15});
    rules[749] = new Rule(-93, new int[]{-57});
    rules[750] = new Rule(-93, new int[]{11,-68,12});
    rules[751] = new Rule(-93, new int[]{133,-93});
    rules[752] = new Rule(-93, new int[]{-195,-93});
    rules[753] = new Rule(-93, new int[]{140,-93});
    rules[754] = new Rule(-93, new int[]{-109});
    rules[755] = new Rule(-93, new int[]{-58});
    rules[756] = new Rule(-15, new int[]{-161});
    rules[757] = new Rule(-15, new int[]{-16});
    rules[758] = new Rule(-112, new int[]{-108,15,-108});
    rules[759] = new Rule(-112, new int[]{-108,15,-112});
    rules[760] = new Rule(-109, new int[]{-128,-108});
    rules[761] = new Rule(-109, new int[]{-108});
    rules[762] = new Rule(-109, new int[]{-112});
    rules[763] = new Rule(-128, new int[]{139});
    rules[764] = new Rule(-128, new int[]{-128,139});
    rules[765] = new Rule(-9, new int[]{-176,-69});
    rules[766] = new Rule(-9, new int[]{-297,-69});
    rules[767] = new Rule(-318, new int[]{-143});
    rules[768] = new Rule(-318, new int[]{-318,7,-134});
    rules[769] = new Rule(-317, new int[]{-318});
    rules[770] = new Rule(-317, new int[]{-318,-295});
    rules[771] = new Rule(-17, new int[]{-108});
    rules[772] = new Rule(-17, new int[]{-15});
    rules[773] = new Rule(-355, new int[]{51,-143,108,-85,10});
    rules[774] = new Rule(-356, new int[]{-355});
    rules[775] = new Rule(-356, new int[]{-356,-355});
    rules[776] = new Rule(-108, new int[]{-143});
    rules[777] = new Rule(-108, new int[]{-187});
    rules[778] = new Rule(-108, new int[]{40,-143});
    rules[779] = new Rule(-108, new int[]{8,-85,9});
    rules[780] = new Rule(-108, new int[]{8,-356,-85,9});
    rules[781] = new Rule(-108, new int[]{-253});
    rules[782] = new Rule(-108, new int[]{-291});
    rules[783] = new Rule(-108, new int[]{-15,7,-134});
    rules[784] = new Rule(-108, new int[]{-17,11,-70,12});
    rules[785] = new Rule(-108, new int[]{-17,17,-116,12});
    rules[786] = new Rule(-108, new int[]{75,-68,75});
    rules[787] = new Rule(-108, new int[]{-108,8,-67,9});
    rules[788] = new Rule(-108, new int[]{-108,7,-144});
    rules[789] = new Rule(-108, new int[]{-58,7,-144});
    rules[790] = new Rule(-108, new int[]{-108,140});
    rules[791] = new Rule(-108, new int[]{-108,4,-295});
    rules[792] = new Rule(-67, new int[]{-70});
    rules[793] = new Rule(-67, new int[]{});
    rules[794] = new Rule(-68, new int[]{-75});
    rules[795] = new Rule(-68, new int[]{});
    rules[796] = new Rule(-75, new int[]{-89});
    rules[797] = new Rule(-75, new int[]{-75,98,-89});
    rules[798] = new Rule(-89, new int[]{-85});
    rules[799] = new Rule(-89, new int[]{-85,6,-85});
    rules[800] = new Rule(-162, new int[]{142});
    rules[801] = new Rule(-162, new int[]{144});
    rules[802] = new Rule(-161, new int[]{-163});
    rules[803] = new Rule(-161, new int[]{143});
    rules[804] = new Rule(-163, new int[]{-162});
    rules[805] = new Rule(-163, new int[]{-163,-162});
    rules[806] = new Rule(-187, new int[]{43,-196});
    rules[807] = new Rule(-203, new int[]{10});
    rules[808] = new Rule(-203, new int[]{10,-202,10});
    rules[809] = new Rule(-204, new int[]{});
    rules[810] = new Rule(-204, new int[]{10,-202});
    rules[811] = new Rule(-202, new int[]{-205});
    rules[812] = new Rule(-202, new int[]{-202,10,-205});
    rules[813] = new Rule(-143, new int[]{141});
    rules[814] = new Rule(-143, new int[]{-147});
    rules[815] = new Rule(-143, new int[]{-148});
    rules[816] = new Rule(-134, new int[]{-143});
    rules[817] = new Rule(-134, new int[]{-289});
    rules[818] = new Rule(-134, new int[]{-290});
    rules[819] = new Rule(-144, new int[]{-143});
    rules[820] = new Rule(-144, new int[]{-289});
    rules[821] = new Rule(-144, new int[]{-187});
    rules[822] = new Rule(-205, new int[]{145});
    rules[823] = new Rule(-205, new int[]{147});
    rules[824] = new Rule(-205, new int[]{148});
    rules[825] = new Rule(-205, new int[]{149});
    rules[826] = new Rule(-205, new int[]{151});
    rules[827] = new Rule(-205, new int[]{150});
    rules[828] = new Rule(-206, new int[]{150});
    rules[829] = new Rule(-206, new int[]{149});
    rules[830] = new Rule(-206, new int[]{145});
    rules[831] = new Rule(-206, new int[]{148});
    rules[832] = new Rule(-147, new int[]{84});
    rules[833] = new Rule(-147, new int[]{85});
    rules[834] = new Rule(-148, new int[]{79});
    rules[835] = new Rule(-148, new int[]{77});
    rules[836] = new Rule(-146, new int[]{83});
    rules[837] = new Rule(-146, new int[]{82});
    rules[838] = new Rule(-146, new int[]{81});
    rules[839] = new Rule(-146, new int[]{80});
    rules[840] = new Rule(-289, new int[]{-146});
    rules[841] = new Rule(-289, new int[]{67});
    rules[842] = new Rule(-289, new int[]{62});
    rules[843] = new Rule(-289, new int[]{126});
    rules[844] = new Rule(-289, new int[]{20});
    rules[845] = new Rule(-289, new int[]{19});
    rules[846] = new Rule(-289, new int[]{61});
    rules[847] = new Rule(-289, new int[]{21});
    rules[848] = new Rule(-289, new int[]{127});
    rules[849] = new Rule(-289, new int[]{128});
    rules[850] = new Rule(-289, new int[]{129});
    rules[851] = new Rule(-289, new int[]{130});
    rules[852] = new Rule(-289, new int[]{131});
    rules[853] = new Rule(-289, new int[]{132});
    rules[854] = new Rule(-289, new int[]{133});
    rules[855] = new Rule(-289, new int[]{134});
    rules[856] = new Rule(-289, new int[]{135});
    rules[857] = new Rule(-289, new int[]{136});
    rules[858] = new Rule(-289, new int[]{22});
    rules[859] = new Rule(-289, new int[]{72});
    rules[860] = new Rule(-289, new int[]{89});
    rules[861] = new Rule(-289, new int[]{23});
    rules[862] = new Rule(-289, new int[]{24});
    rules[863] = new Rule(-289, new int[]{27});
    rules[864] = new Rule(-289, new int[]{28});
    rules[865] = new Rule(-289, new int[]{29});
    rules[866] = new Rule(-289, new int[]{70});
    rules[867] = new Rule(-289, new int[]{97});
    rules[868] = new Rule(-289, new int[]{30});
    rules[869] = new Rule(-289, new int[]{90});
    rules[870] = new Rule(-289, new int[]{31});
    rules[871] = new Rule(-289, new int[]{32});
    rules[872] = new Rule(-289, new int[]{25});
    rules[873] = new Rule(-289, new int[]{102});
    rules[874] = new Rule(-289, new int[]{99});
    rules[875] = new Rule(-289, new int[]{33});
    rules[876] = new Rule(-289, new int[]{34});
    rules[877] = new Rule(-289, new int[]{35});
    rules[878] = new Rule(-289, new int[]{38});
    rules[879] = new Rule(-289, new int[]{39});
    rules[880] = new Rule(-289, new int[]{40});
    rules[881] = new Rule(-289, new int[]{101});
    rules[882] = new Rule(-289, new int[]{41});
    rules[883] = new Rule(-289, new int[]{42});
    rules[884] = new Rule(-289, new int[]{44});
    rules[885] = new Rule(-289, new int[]{45});
    rules[886] = new Rule(-289, new int[]{46});
    rules[887] = new Rule(-289, new int[]{95});
    rules[888] = new Rule(-289, new int[]{47});
    rules[889] = new Rule(-289, new int[]{100});
    rules[890] = new Rule(-289, new int[]{48});
    rules[891] = new Rule(-289, new int[]{26});
    rules[892] = new Rule(-289, new int[]{49});
    rules[893] = new Rule(-289, new int[]{69});
    rules[894] = new Rule(-289, new int[]{96});
    rules[895] = new Rule(-289, new int[]{50});
    rules[896] = new Rule(-289, new int[]{51});
    rules[897] = new Rule(-289, new int[]{52});
    rules[898] = new Rule(-289, new int[]{53});
    rules[899] = new Rule(-289, new int[]{54});
    rules[900] = new Rule(-289, new int[]{55});
    rules[901] = new Rule(-289, new int[]{56});
    rules[902] = new Rule(-289, new int[]{57});
    rules[903] = new Rule(-289, new int[]{59});
    rules[904] = new Rule(-289, new int[]{103});
    rules[905] = new Rule(-289, new int[]{104});
    rules[906] = new Rule(-289, new int[]{107});
    rules[907] = new Rule(-289, new int[]{105});
    rules[908] = new Rule(-289, new int[]{106});
    rules[909] = new Rule(-289, new int[]{60});
    rules[910] = new Rule(-289, new int[]{73});
    rules[911] = new Rule(-289, new int[]{36});
    rules[912] = new Rule(-289, new int[]{37});
    rules[913] = new Rule(-289, new int[]{68});
    rules[914] = new Rule(-289, new int[]{145});
    rules[915] = new Rule(-289, new int[]{58});
    rules[916] = new Rule(-289, new int[]{137});
    rules[917] = new Rule(-289, new int[]{138});
    rules[918] = new Rule(-289, new int[]{78});
    rules[919] = new Rule(-289, new int[]{150});
    rules[920] = new Rule(-289, new int[]{149});
    rules[921] = new Rule(-289, new int[]{71});
    rules[922] = new Rule(-289, new int[]{151});
    rules[923] = new Rule(-289, new int[]{147});
    rules[924] = new Rule(-289, new int[]{148});
    rules[925] = new Rule(-289, new int[]{146});
    rules[926] = new Rule(-290, new int[]{43});
    rules[927] = new Rule(-196, new int[]{113});
    rules[928] = new Rule(-196, new int[]{114});
    rules[929] = new Rule(-196, new int[]{115});
    rules[930] = new Rule(-196, new int[]{116});
    rules[931] = new Rule(-196, new int[]{118});
    rules[932] = new Rule(-196, new int[]{119});
    rules[933] = new Rule(-196, new int[]{120});
    rules[934] = new Rule(-196, new int[]{121});
    rules[935] = new Rule(-196, new int[]{122});
    rules[936] = new Rule(-196, new int[]{123});
    rules[937] = new Rule(-196, new int[]{126});
    rules[938] = new Rule(-196, new int[]{127});
    rules[939] = new Rule(-196, new int[]{128});
    rules[940] = new Rule(-196, new int[]{129});
    rules[941] = new Rule(-196, new int[]{130});
    rules[942] = new Rule(-196, new int[]{131});
    rules[943] = new Rule(-196, new int[]{132});
    rules[944] = new Rule(-196, new int[]{133});
    rules[945] = new Rule(-196, new int[]{135});
    rules[946] = new Rule(-196, new int[]{137});
    rules[947] = new Rule(-196, new int[]{138});
    rules[948] = new Rule(-196, new int[]{-190});
    rules[949] = new Rule(-196, new int[]{117});
    rules[950] = new Rule(-190, new int[]{108});
    rules[951] = new Rule(-190, new int[]{109});
    rules[952] = new Rule(-190, new int[]{110});
    rules[953] = new Rule(-190, new int[]{111});
    rules[954] = new Rule(-190, new int[]{112});
    rules[955] = new Rule(-97, new int[]{18,-24,98,-23,9});
    rules[956] = new Rule(-23, new int[]{-97});
    rules[957] = new Rule(-23, new int[]{-143});
    rules[958] = new Rule(-24, new int[]{-23});
    rules[959] = new Rule(-24, new int[]{-24,98,-23});
    rules[960] = new Rule(-99, new int[]{-98});
    rules[961] = new Rule(-99, new int[]{-97});
    rules[962] = new Rule(-77, new int[]{-99});
    rules[963] = new Rule(-77, new int[]{-77,98,-99});
    rules[964] = new Rule(-319, new int[]{-143,125,-325});
    rules[965] = new Rule(-319, new int[]{8,9,-322,125,-325});
    rules[966] = new Rule(-319, new int[]{8,-143,5,-271,9,-322,125,-325});
    rules[967] = new Rule(-319, new int[]{8,-143,10,-323,9,-322,125,-325});
    rules[968] = new Rule(-319, new int[]{8,-143,5,-271,10,-323,9,-322,125,-325});
    rules[969] = new Rule(-319, new int[]{8,-99,98,-77,-321,-328,9,-332});
    rules[970] = new Rule(-319, new int[]{-97,-332});
    rules[971] = new Rule(-319, new int[]{-320});
    rules[972] = new Rule(-328, new int[]{});
    rules[973] = new Rule(-328, new int[]{10,-323});
    rules[974] = new Rule(-332, new int[]{-322,125,-325});
    rules[975] = new Rule(-320, new int[]{35,-322,125,-325});
    rules[976] = new Rule(-320, new int[]{35,8,9,-322,125,-325});
    rules[977] = new Rule(-320, new int[]{35,8,-323,9,-322,125,-325});
    rules[978] = new Rule(-320, new int[]{42,125,-326});
    rules[979] = new Rule(-320, new int[]{42,8,9,125,-326});
    rules[980] = new Rule(-320, new int[]{42,8,-323,9,125,-326});
    rules[981] = new Rule(-323, new int[]{-324});
    rules[982] = new Rule(-323, new int[]{-323,10,-324});
    rules[983] = new Rule(-324, new int[]{-154,-321});
    rules[984] = new Rule(-321, new int[]{});
    rules[985] = new Rule(-321, new int[]{5,-271});
    rules[986] = new Rule(-322, new int[]{});
    rules[987] = new Rule(-322, new int[]{5,-273});
    rules[988] = new Rule(-327, new int[]{-251});
    rules[989] = new Rule(-327, new int[]{-149});
    rules[990] = new Rule(-327, new int[]{-315});
    rules[991] = new Rule(-327, new int[]{-243});
    rules[992] = new Rule(-327, new int[]{-120});
    rules[993] = new Rule(-327, new int[]{-119});
    rules[994] = new Rule(-327, new int[]{-121});
    rules[995] = new Rule(-327, new int[]{-35});
    rules[996] = new Rule(-327, new int[]{-298});
    rules[997] = new Rule(-327, new int[]{-165});
    rules[998] = new Rule(-327, new int[]{-244});
    rules[999] = new Rule(-327, new int[]{-122});
    rules[1000] = new Rule(-325, new int[]{-101});
    rules[1001] = new Rule(-325, new int[]{-327});
    rules[1002] = new Rule(-326, new int[]{-208});
    rules[1003] = new Rule(-326, new int[]{-4});
    rules[1004] = new Rule(-326, new int[]{-327});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
    {
  CurrentSemanticValue = new Union();
    switch (action)
    {
      case 2: // parse_goal -> program_file
{ root = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 3: // parse_goal -> unit_file
{ root = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 4: // parse_goal -> parts
{ root = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 5: // parse_goal -> tkShortProgram, uses_clause_one_or_empty, 
              //               decl_sect_list_proc_func_only, stmt_list
{ 
			var stl = ValueStack[ValueStack.Depth-1].stn as statement_list;
			stl.left_logical_bracket = new token_info("");
			stl.right_logical_bracket = new token_info("");
			var ul = ValueStack[ValueStack.Depth-3].stn as uses_list;
			root = CurrentSemanticValue.stn = NewProgramModule(null, null, ul, new block(ValueStack[ValueStack.Depth-2].stn as declarations, stl, LocationStack[LocationStack.Depth-1]), new token_info(""), LexLocation.MergeAll(LocationStack[LocationStack.Depth-3],LocationStack[LocationStack.Depth-2],LocationStack[LocationStack.Depth-1])); 
		}
        break;
      case 6: // parse_goal -> tkShortSFProgram, uses_clause_one_or_empty, 
              //               decl_sect_list_proc_func_only, stmt_list
{
			var stl = ValueStack[ValueStack.Depth-1].stn as statement_list;
			stl.left_logical_bracket = new token_info("");
			stl.right_logical_bracket = new token_info("");
			var un = new unit_or_namespace(new ident_list("SF"),null);
			var ul = ValueStack[ValueStack.Depth-3].stn as uses_list;
			if (ul == null)
			//var un1 = new unit_or_namespace(new ident_list("School"),null);
				ul = new uses_list(un,null);
			else ul.Insert(0,un);
			//ul.Add(un1);
			root = CurrentSemanticValue.stn = NewProgramModule(null, null, ul, new block(ValueStack[ValueStack.Depth-2].stn as declarations, stl, CurrentLocationSpan), new token_info(""), LexLocation.MergeAll(LocationStack[LocationStack.Depth-3],LocationStack[LocationStack.Depth-2],LocationStack[LocationStack.Depth-1])); 
		}
        break;
      case 7: // parts -> tkParseModeExpression, expr
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 8: // parts -> tkParseModeExpression, tkType, type_decl_identifier
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 9: // parts -> tkParseModeType, variable_as_type
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 10: // parts -> tkParseModeStatement, stmt_or_expression
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 11: // stmt_or_expression -> expr
{ CurrentSemanticValue.stn = new expression_as_statement(ValueStack[ValueStack.Depth-1].ex,CurrentLocationSpan);}
        break;
      case 12: // stmt_or_expression -> assignment
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 13: // stmt_or_expression -> var_stmt
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 14: // optional_head_compiler_directives -> /* empty */
{ CurrentSemanticValue.ob = null; }
        break;
      case 15: // optional_head_compiler_directives -> head_compiler_directives
{ CurrentSemanticValue.ob = null; }
        break;
      case 16: // head_compiler_directives -> one_compiler_directive
{ CurrentSemanticValue.ob = null; }
        break;
      case 17: // head_compiler_directives -> head_compiler_directives, one_compiler_directive
{ CurrentSemanticValue.ob = null; }
        break;
      case 18: // one_compiler_directive -> tkDirectiveName, tkIdentifier
{
			parsertools.AddErrorFromResource("UNSUPPORTED_OLD_DIRECTIVES",CurrentLocationSpan);
			CurrentSemanticValue.ob = null;
        }
        break;
      case 19: // one_compiler_directive -> tkDirectiveName, tkStringLiteral
{
			parsertools.AddErrorFromResource("UNSUPPORTED_OLD_DIRECTIVES",CurrentLocationSpan);
			CurrentSemanticValue.ob = null;
        }
        break;
      case 20: // program_file -> program_header, optional_head_compiler_directives, uses_clause, 
               //                 program_block, optional_tk_point
{ 
			CurrentSemanticValue.stn = NewProgramModule(ValueStack[ValueStack.Depth-5].stn as program_name, ValueStack[ValueStack.Depth-4].ob, ValueStack[ValueStack.Depth-3].stn as uses_list, ValueStack[ValueStack.Depth-2].stn, ValueStack[ValueStack.Depth-1].ob, CurrentLocationSpan);
        }
        break;
      case 21: // optional_tk_point -> tkPoint
{ CurrentSemanticValue.ob = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 22: // optional_tk_point -> tkSemiColon
{ CurrentSemanticValue.ob = null; }
        break;
      case 23: // optional_tk_point -> tkColon
{ CurrentSemanticValue.ob = null; }
        break;
      case 24: // optional_tk_point -> tkComma
{ CurrentSemanticValue.ob = null; }
        break;
      case 25: // optional_tk_point -> tkDotDot
{ CurrentSemanticValue.ob = null; }
        break;
      case 27: // program_header -> /* empty */
{ CurrentSemanticValue.stn = null; }
        break;
      case 28: // program_header -> tkProgram, identifier, program_heading_2
{ CurrentSemanticValue.stn = new program_name(ValueStack[ValueStack.Depth-2].id,CurrentLocationSpan); }
        break;
      case 29: // program_heading_2 -> tkSemiColon
{ CurrentSemanticValue.ob = null; }
        break;
      case 30: // program_heading_2 -> tkRoundOpen, program_param_list, tkRoundClose, tkSemiColon
{ CurrentSemanticValue.ob = null; }
        break;
      case 31: // program_param_list -> program_param
{ CurrentSemanticValue.ob = null; }
        break;
      case 32: // program_param_list -> program_param_list, tkComma, program_param
{ CurrentSemanticValue.ob = null; }
        break;
      case 33: // program_param -> identifier
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 34: // program_block -> program_decl_sect_list, compound_stmt
{ 
			CurrentSemanticValue.stn = new block(ValueStack[ValueStack.Depth-2].stn as declarations, ValueStack[ValueStack.Depth-1].stn as statement_list, CurrentLocationSpan);
        }
        break;
      case 35: // program_decl_sect_list -> decl_sect_list
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 36: // ident_or_keyword_pointseparator_list -> identifier_or_keyword
{ 
			CurrentSemanticValue.stn = new ident_list(ValueStack[ValueStack.Depth-1].id, CurrentLocationSpan);
		}
        break;
      case 37: // ident_or_keyword_pointseparator_list -> ident_or_keyword_pointseparator_list, 
               //                                         tkPoint, identifier_or_keyword
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as ident_list).Add(ValueStack[ValueStack.Depth-1].id, CurrentLocationSpan);
		}
        break;
      case 38: // uses_clause_one -> tkUses, used_units_list, tkSemiColon
{
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-2].stn;
			CurrentSemanticValue.stn.source_context = CurrentLocationSpan;
		}
        break;
      case 39: // uses_clause_one_or_empty -> /* empty */
{ 
			CurrentSemanticValue.stn = null; 
		}
        break;
      case 40: // uses_clause_one_or_empty -> uses_clause_one
{
			if (parsertools.build_tree_for_formatter)
				CurrentSemanticValue.stn = new uses_closure(ValueStack[ValueStack.Depth-1].stn as uses_list,CurrentLocationSpan);
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn;
		}
        break;
      case 41: // uses_clause -> /* empty */
{ 
			CurrentSemanticValue.stn = null; 
		}
        break;
      case 42: // uses_clause -> uses_clause, uses_clause_one
{ 
   			if (parsertools.build_tree_for_formatter)
   			{
	        	if (ValueStack[ValueStack.Depth-2].stn == null)
                {
	        		CurrentSemanticValue.stn = new uses_closure(ValueStack[ValueStack.Depth-1].stn as uses_list,CurrentLocationSpan);
                }
	        	else {
                    (ValueStack[ValueStack.Depth-2].stn as uses_closure).AddUsesList(ValueStack[ValueStack.Depth-1].stn as uses_list,CurrentLocationSpan);
                    CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-2].stn;
                }
   			}
   			else 
   			{
	        	if (ValueStack[ValueStack.Depth-2].stn == null)
                {
                    CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn;
                    CurrentSemanticValue.stn.source_context = CurrentLocationSpan;
                }
	        	else 
                {
                    (ValueStack[ValueStack.Depth-2].stn as uses_list).AddUsesList(ValueStack[ValueStack.Depth-1].stn as uses_list,CurrentLocationSpan);
                    CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-2].stn;
                    CurrentSemanticValue.stn.source_context = CurrentLocationSpan;
                }
			}
		}
        break;
      case 43: // used_units_list -> used_unit_name
{ 
		  CurrentSemanticValue.stn = new uses_list(ValueStack[ValueStack.Depth-1].stn as unit_or_namespace,CurrentLocationSpan);
        }
        break;
      case 44: // used_units_list -> used_units_list, tkComma, used_unit_name
{ 
		  CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as uses_list).Add(ValueStack[ValueStack.Depth-1].stn as unit_or_namespace, CurrentLocationSpan);
        }
        break;
      case 45: // used_unit_name -> ident_or_keyword_pointseparator_list
{ 
			CurrentSemanticValue.stn = new unit_or_namespace(ValueStack[ValueStack.Depth-1].stn as ident_list,CurrentLocationSpan); 
		}
        break;
      case 46: // used_unit_name -> ident_or_keyword_pointseparator_list, tkIn, tkStringLiteral
{ 
        	if (ValueStack[ValueStack.Depth-1].stn is char_const _cc)
        		ValueStack[ValueStack.Depth-1].stn = new string_const(_cc.cconst.ToString());
			CurrentSemanticValue.stn = new uses_unit_in(ValueStack[ValueStack.Depth-3].stn as ident_list, ValueStack[ValueStack.Depth-1].stn as string_const, CurrentLocationSpan);
        }
        break;
      case 47: // unit_file -> attribute_declarations, unit_header, interface_part, 
               //              implementation_part, initialization_part, tkPoint
{ 
			CurrentSemanticValue.stn = new unit_module(ValueStack[ValueStack.Depth-5].stn as unit_name, ValueStack[ValueStack.Depth-4].stn as interface_node, ValueStack[ValueStack.Depth-3].stn as implementation_node, (ValueStack[ValueStack.Depth-2].stn as initfinal_part).initialization_sect, (ValueStack[ValueStack.Depth-2].stn as initfinal_part).finalization_sect, ValueStack[ValueStack.Depth-6].stn as attribute_list, CurrentLocationSpan);                    
		}
        break;
      case 48: // unit_file -> attribute_declarations, unit_header, abc_interface_part, 
               //              initialization_part, tkPoint
{ 
			CurrentSemanticValue.stn = new unit_module(ValueStack[ValueStack.Depth-4].stn as unit_name, ValueStack[ValueStack.Depth-3].stn as interface_node, null, (ValueStack[ValueStack.Depth-2].stn as initfinal_part).initialization_sect, (ValueStack[ValueStack.Depth-2].stn as initfinal_part).finalization_sect, ValueStack[ValueStack.Depth-5].stn as attribute_list, CurrentLocationSpan);
        }
        break;
      case 49: // unit_header -> unit_key_word, unit_name, tkSemiColon, 
               //                optional_head_compiler_directives
{ 
			CurrentSemanticValue.stn = NewUnitHeading(new ident(ValueStack[ValueStack.Depth-4].ti.text, LocationStack[LocationStack.Depth-4]), ValueStack[ValueStack.Depth-3].id, CurrentLocationSpan); 
		}
        break;
      case 50: // unit_header -> tkNamespace, ident_or_keyword_pointseparator_list, tkSemiColon, 
               //                optional_head_compiler_directives
{
            CurrentSemanticValue.stn = NewNamespaceHeading(new ident(ValueStack[ValueStack.Depth-4].ti.text, LocationStack[LocationStack.Depth-4]), ValueStack[ValueStack.Depth-3].stn as ident_list, CurrentLocationSpan);
        }
        break;
      case 51: // unit_key_word -> tkUnit
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 52: // unit_key_word -> tkLibrary
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 53: // unit_name -> identifier
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 54: // interface_part -> tkInterface, uses_clause, interface_decl_sect_list
{ 
			CurrentSemanticValue.stn = new interface_node(ValueStack[ValueStack.Depth-1].stn as declarations, ValueStack[ValueStack.Depth-2].stn as uses_list, null, LexLocation.MergeAll(LocationStack[LocationStack.Depth-3],LocationStack[LocationStack.Depth-2],LocationStack[LocationStack.Depth-1])); 
        }
        break;
      case 55: // implementation_part -> tkImplementation, uses_clause, decl_sect_list
{ 
			CurrentSemanticValue.stn = new implementation_node(ValueStack[ValueStack.Depth-2].stn as uses_list, ValueStack[ValueStack.Depth-1].stn as declarations, null, LexLocation.MergeAll(LocationStack[LocationStack.Depth-3],LocationStack[LocationStack.Depth-2],LocationStack[LocationStack.Depth-1])); 
        }
        break;
      case 56: // abc_interface_part -> uses_clause, decl_sect_list
{ 
			CurrentSemanticValue.stn = new interface_node(ValueStack[ValueStack.Depth-1].stn as declarations, ValueStack[ValueStack.Depth-2].stn as uses_list, null, null); 
        }
        break;
      case 57: // initialization_part -> tkEnd
{ 
			CurrentSemanticValue.stn = new initfinal_part(); 
			CurrentSemanticValue.stn.source_context = CurrentLocationSpan;
		}
        break;
      case 58: // initialization_part -> tkInitialization, stmt_list, tkEnd
{ 
		  CurrentSemanticValue.stn = new initfinal_part(ValueStack[ValueStack.Depth-3].ti, ValueStack[ValueStack.Depth-2].stn as statement_list, ValueStack[ValueStack.Depth-1].ti, null, null, CurrentLocationSpan);
        }
        break;
      case 59: // initialization_part -> tkInitialization, stmt_list, tkFinalization, stmt_list, 
               //                        tkEnd
{ 
		  CurrentSemanticValue.stn = new initfinal_part(ValueStack[ValueStack.Depth-5].ti, ValueStack[ValueStack.Depth-4].stn as statement_list, ValueStack[ValueStack.Depth-3].ti, ValueStack[ValueStack.Depth-2].stn as statement_list, ValueStack[ValueStack.Depth-1].ti, CurrentLocationSpan);
        }
        break;
      case 60: // initialization_part -> tkBegin, stmt_list, tkEnd
{ 
		  CurrentSemanticValue.stn = new initfinal_part(ValueStack[ValueStack.Depth-3].ti, ValueStack[ValueStack.Depth-2].stn as statement_list, ValueStack[ValueStack.Depth-1].ti, null, null, CurrentLocationSpan);
        }
        break;
      case 61: // interface_decl_sect_list -> int_decl_sect_list1
{
			if ((ValueStack[ValueStack.Depth-1].stn as declarations).Count > 0) 
				CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; 
			else 
				CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn;
		}
        break;
      case 62: // int_decl_sect_list1 -> /* empty */
{ 
			CurrentSemanticValue.stn = new declarations();  
			if (GlobalDecls==null) 
				GlobalDecls = CurrentSemanticValue.stn as declarations;
		}
        break;
      case 63: // int_decl_sect_list1 -> int_decl_sect_list1, int_decl_sect
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-2].stn as declarations).Add(ValueStack[ValueStack.Depth-1].stn as declaration, CurrentLocationSpan);
        }
        break;
      case 64: // decl_sect_list -> decl_sect_list1
{
			if ((ValueStack[ValueStack.Depth-1].stn as declarations).Count > 0) 
				CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; 
			else 
				CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn;
		}
        break;
      case 65: // decl_sect_list_proc_func_only -> /* empty */
{ 
			CurrentSemanticValue.stn = new declarations(); 
			if (GlobalDecls==null) 
				GlobalDecls = CurrentSemanticValue.stn as declarations;
		}
        break;
      case 66: // decl_sect_list_proc_func_only -> decl_sect_list_proc_func_only, 
               //                                  proc_func_decl_noclass
{
			var dcl = ValueStack[ValueStack.Depth-2].stn as declarations;
			if (dcl.Count == 0)			
				CurrentSemanticValue.stn = dcl.Add(ValueStack[ValueStack.Depth-1].stn as declaration, LocationStack[LocationStack.Depth-1]);
			else
			{
				var sc = dcl.source_context;
				sc = sc.Merge(ValueStack[ValueStack.Depth-1].stn.source_context);
				CurrentSemanticValue.stn = dcl.Add(ValueStack[ValueStack.Depth-1].stn as declaration, LocationStack[LocationStack.Depth-1]);
				CurrentSemanticValue.stn.source_context = sc;			
			}
		}
        break;
      case 67: // decl_sect_list1 -> /* empty */
{ 
			CurrentSemanticValue.stn = new declarations(); 
			if (GlobalDecls==null) 
				GlobalDecls = CurrentSemanticValue.stn as declarations;
		}
        break;
      case 68: // decl_sect_list1 -> decl_sect_list1, decl_sect
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-2].stn as declarations).Add(ValueStack[ValueStack.Depth-1].stn as declaration, CurrentLocationSpan);
        }
        break;
      case 69: // inclass_decl_sect_list -> inclass_decl_sect_list1
{
			if ((ValueStack[ValueStack.Depth-1].stn as declarations).Count > 0) 
				CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; 
			else 
				CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn;
		}
        break;
      case 70: // inclass_decl_sect_list1 -> /* empty */
{ 
        	CurrentSemanticValue.stn = new declarations(); 
        }
        break;
      case 71: // inclass_decl_sect_list1 -> inclass_decl_sect_list1, abc_decl_sect
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-2].stn as declarations).Add(ValueStack[ValueStack.Depth-1].stn as declaration, CurrentLocationSpan);
        }
        break;
      case 72: // int_decl_sect -> const_decl_sect
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 73: // int_decl_sect -> res_str_decl_sect
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 74: // int_decl_sect -> type_decl_sect
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 75: // int_decl_sect -> var_decl_sect
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 76: // int_decl_sect -> int_proc_header
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 77: // int_decl_sect -> int_func_header
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 78: // decl_sect -> label_decl_sect
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 79: // decl_sect -> const_decl_sect
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 80: // decl_sect -> res_str_decl_sect
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 81: // decl_sect -> type_decl_sect
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 82: // decl_sect -> var_decl_sect
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 83: // decl_sect -> proc_func_constr_destr_decl_with_attr
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 84: // proc_func_constr_destr_decl -> proc_func_decl
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 85: // proc_func_constr_destr_decl -> constr_destr_decl
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 86: // proc_func_constr_destr_decl_with_attr -> attribute_declarations, 
               //                                          proc_func_constr_destr_decl
{
		    (ValueStack[ValueStack.Depth-1].stn as procedure_definition).AssignAttrList(ValueStack[ValueStack.Depth-2].stn as attribute_list);
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn;
		}
        break;
      case 87: // abc_decl_sect -> label_decl_sect
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 88: // abc_decl_sect -> const_decl_sect
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 89: // abc_decl_sect -> res_str_decl_sect
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 90: // abc_decl_sect -> type_decl_sect
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 91: // abc_decl_sect -> var_decl_sect
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 92: // int_proc_header -> attribute_declarations, proc_header
{  
			CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td;
			(CurrentSemanticValue.td as procedure_header).attributes = ValueStack[ValueStack.Depth-2].stn as attribute_list;
        }
        break;
      case 93: // int_proc_header -> attribute_declarations, proc_header, tkForward, tkSemiColon
{  
			CurrentSemanticValue.td = NewProcedureHeader(ValueStack[ValueStack.Depth-4].stn as attribute_list, ValueStack[ValueStack.Depth-3].td as procedure_header, ValueStack[ValueStack.Depth-2].id as procedure_attribute, CurrentLocationSpan);
		}
        break;
      case 94: // int_func_header -> attribute_declarations, func_header
{  
			CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td;
			(CurrentSemanticValue.td as procedure_header).attributes = ValueStack[ValueStack.Depth-2].stn as attribute_list;
        }
        break;
      case 95: // int_func_header -> attribute_declarations, func_header, tkForward, tkSemiColon
{  
			CurrentSemanticValue.td = NewProcedureHeader(ValueStack[ValueStack.Depth-4].stn as attribute_list, ValueStack[ValueStack.Depth-3].td as procedure_header, ValueStack[ValueStack.Depth-2].id as procedure_attribute, CurrentLocationSpan);
		}
        break;
      case 96: // label_decl_sect -> tkLabel, label_list, tkSemiColon
{ 
			CurrentSemanticValue.stn = new label_definitions(ValueStack[ValueStack.Depth-2].stn as ident_list, CurrentLocationSpan); 
		}
        break;
      case 97: // label_list -> label_name
{ 
			CurrentSemanticValue.stn = new ident_list(ValueStack[ValueStack.Depth-1].id, CurrentLocationSpan);
		}
        break;
      case 98: // label_list -> label_list, tkComma, label_name
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as ident_list).Add(ValueStack[ValueStack.Depth-1].id, CurrentLocationSpan);
		}
        break;
      case 99: // label_name -> tkInteger
{ 
			CurrentSemanticValue.id = new ident(ValueStack[ValueStack.Depth-1].ex.ToString(), CurrentLocationSpan);
		}
        break;
      case 100: // label_name -> identifier
{ 
			CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; 
		}
        break;
      case 101: // const_decl_sect -> tkConst, const_decl
{ 
			CurrentSemanticValue.stn = new consts_definitions_list(ValueStack[ValueStack.Depth-1].stn as const_definition, CurrentLocationSpan);
		}
        break;
      case 102: // const_decl_sect -> const_decl_sect, const_decl
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-2].stn as consts_definitions_list).Add(ValueStack[ValueStack.Depth-1].stn as const_definition, CurrentLocationSpan);
		}
        break;
      case 103: // res_str_decl_sect -> tkResourceString, const_decl
{ 
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; 
		}
        break;
      case 104: // res_str_decl_sect -> res_str_decl_sect, const_decl
{ 
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-2].stn; 
		}
        break;
      case 105: // type_decl_sect -> tkType, type_decl
{ 
            CurrentSemanticValue.stn = new type_declarations(ValueStack[ValueStack.Depth-1].stn as type_declaration, CurrentLocationSpan);
		}
        break;
      case 106: // type_decl_sect -> type_decl_sect, type_decl
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-2].stn as type_declarations).Add(ValueStack[ValueStack.Depth-1].stn as type_declaration, CurrentLocationSpan);
		}
        break;
      case 107: // var_decl_with_assign_var_tuple -> var_decl
{ 
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; 
		}
        break;
      case 108: // var_decl_with_assign_var_tuple -> tkRoundOpen, identifier, tkComma, ident_list, 
                //                                   tkRoundClose, tkAssign, expr_l1, 
                //                                   tkSemiColon
{
			(ValueStack[ValueStack.Depth-5].stn as ident_list).Insert(0,ValueStack[ValueStack.Depth-7].id);
			ValueStack[ValueStack.Depth-5].stn.source_context = LexLocation.MergeAll(LocationStack[LocationStack.Depth-8],LocationStack[LocationStack.Depth-7],LocationStack[LocationStack.Depth-6],LocationStack[LocationStack.Depth-5],LocationStack[LocationStack.Depth-4]);
			CurrentSemanticValue.stn = new var_tuple_def_statement(ValueStack[ValueStack.Depth-5].stn as ident_list, ValueStack[ValueStack.Depth-2].ex, CurrentLocationSpan);
		}
        break;
      case 109: // var_decl_sect -> tkVar, var_decl_with_assign_var_tuple
{ 
			CurrentSemanticValue.stn = new variable_definitions(ValueStack[ValueStack.Depth-1].stn as var_def_statement, CurrentLocationSpan);
		}
        break;
      case 110: // var_decl_sect -> tkEvent, var_decl_with_assign_var_tuple
{ 
			CurrentSemanticValue.stn = new variable_definitions(ValueStack[ValueStack.Depth-1].stn as var_def_statement, CurrentLocationSpan);                        
			(ValueStack[ValueStack.Depth-1].stn as var_def_statement).is_event = true;
        }
        break;
      case 111: // var_decl_sect -> var_decl_sect, var_decl_with_assign_var_tuple
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-2].stn as variable_definitions).Add(ValueStack[ValueStack.Depth-1].stn as var_def_statement, CurrentLocationSpan);
		}
        break;
      case 112: // const_decl -> only_const_decl, tkSemiColon
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-2].stn; }
        break;
      case 113: // only_const_decl -> const_name, tkEqual, init_const_expr
{ 
			CurrentSemanticValue.stn = new simple_const_definition(ValueStack[ValueStack.Depth-3].id, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan); 
		}
        break;
      case 114: // only_const_decl -> const_name, tkColon, type_ref, tkEqual, typed_const
{ 
			CurrentSemanticValue.stn = new typed_const_definition(ValueStack[ValueStack.Depth-5].id, ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-3].td, CurrentLocationSpan);
		}
        break;
      case 115: // init_const_expr -> const_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 116: // init_const_expr -> array_const
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 117: // const_name -> identifier
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 118: // const_relop_expr -> const_simple_expr
{ 
			CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; 
		}
        break;
      case 119: // const_relop_expr -> const_relop_expr, const_relop, const_simple_expr
{ 
			CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan); 
		}
        break;
      case 120: // const_expr -> const_relop_expr
{ 
			CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; 
		}
        break;
      case 121: // const_expr -> question_constexpr
{ 
			CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; 
		}
        break;
      case 122: // const_expr -> const_expr, tkDoubleQuestion, const_relop_expr
{ CurrentSemanticValue.ex = new double_question_node(ValueStack[ValueStack.Depth-3].ex as expression, ValueStack[ValueStack.Depth-1].ex as expression, CurrentLocationSpan);}
        break;
      case 123: // question_constexpr -> const_expr, tkQuestion, const_expr, tkColon, const_expr
{ CurrentSemanticValue.ex = new question_colon_expression(ValueStack[ValueStack.Depth-5].ex, ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan); }
        break;
      case 124: // const_relop -> tkEqual
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 125: // const_relop -> tkNotEqual
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 126: // const_relop -> tkLower
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 127: // const_relop -> tkGreater
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 128: // const_relop -> tkLowerEqual
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 129: // const_relop -> tkGreaterEqual
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 130: // const_relop -> tkIn
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 131: // const_simple_expr -> const_term
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 132: // const_simple_expr -> const_simple_expr, const_addop, const_term
{ CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan); }
        break;
      case 133: // const_addop -> tkPlus
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 134: // const_addop -> tkMinus
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 135: // const_addop -> tkOr
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 136: // const_addop -> tkXor
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 137: // as_is_constexpr -> const_term, typecast_op, simple_or_template_type_reference
{ 
			CurrentSemanticValue.ex = NewAsIsConstexpr(ValueStack[ValueStack.Depth-3].ex, (op_typecast)ValueStack[ValueStack.Depth-2].ob, ValueStack[ValueStack.Depth-1].td, CurrentLocationSpan);                                
		}
        break;
      case 138: // power_constexpr -> const_factor_without_unary_op, tkStarStar, const_factor
{ CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan); }
        break;
      case 139: // power_constexpr -> const_factor_without_unary_op, tkStarStar, power_constexpr
{ CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,(ValueStack[ValueStack.Depth-2].op).type, CurrentLocationSpan); }
        break;
      case 140: // power_constexpr -> sign, power_constexpr
{ CurrentSemanticValue.ex = new un_expr(ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan); }
        break;
      case 141: // const_term -> const_factor
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 142: // const_term -> as_is_constexpr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 143: // const_term -> power_constexpr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 144: // const_term -> const_term, const_mulop, const_factor
{ CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan); }
        break;
      case 145: // const_term -> const_term, const_mulop, power_constexpr
{ CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,(ValueStack[ValueStack.Depth-2].op).type, CurrentLocationSpan); }
        break;
      case 146: // const_mulop -> tkStar
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 147: // const_mulop -> tkSlash
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 148: // const_mulop -> tkDiv
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 149: // const_mulop -> tkMod
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 150: // const_mulop -> tkShl
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 151: // const_mulop -> tkShr
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 152: // const_mulop -> tkAnd
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 153: // const_factor_without_unary_op -> const_variable
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 154: // const_factor_without_unary_op -> tkRoundOpen, const_expr, tkRoundClose
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-2].ex; }
        break;
      case 155: // const_factor -> const_variable
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 156: // const_factor -> const_set
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 157: // const_factor -> tkNil
{ 
			CurrentSemanticValue.ex = new nil_const();  
			CurrentSemanticValue.ex.source_context = CurrentLocationSpan;
		}
        break;
      case 158: // const_factor -> tkAddressOf, const_factor
{ 
			CurrentSemanticValue.ex = new get_address(ValueStack[ValueStack.Depth-1].ex as addressed_value, CurrentLocationSpan);  
		}
        break;
      case 159: // const_factor -> tkRoundOpen, const_expr, tkRoundClose
{ 
	 	    CurrentSemanticValue.ex = new bracket_expr(ValueStack[ValueStack.Depth-2].ex, CurrentLocationSpan); 
		}
        break;
      case 160: // const_factor -> tkNot, const_factor
{ 
			CurrentSemanticValue.ex = new un_expr(ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan); 
		}
        break;
      case 161: // const_factor -> sign, const_factor
{ 
		    // ������ ��������� ����� ��������
			if (ValueStack[ValueStack.Depth-2].op.type == Operators.Minus)
			{
			    var i64 = ValueStack[ValueStack.Depth-1].ex as int64_const;
				if (i64 != null && i64.val == (Int64)Int32.MaxValue + 1)
				{
					CurrentSemanticValue.ex = new int32_const(Int32.MinValue,CurrentLocationSpan);
					break;
				}
				var ui64 = ValueStack[ValueStack.Depth-1].ex as uint64_const;
				if (ui64 != null && ui64.val == (UInt64)Int64.MaxValue + 1)
				{
					CurrentSemanticValue.ex = new int64_const(Int64.MinValue,CurrentLocationSpan);
					break;
				}
				if (ui64 != null && ui64.val > (UInt64)Int64.MaxValue + 1)
				{
					parsertools.AddErrorFromResource("BAD_INT2",CurrentLocationSpan);
					break;
				}
			    // ����� ������� ���������� ��������� � �������������� �������
			}
			CurrentSemanticValue.ex = new un_expr(ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan); 
		}
        break;
      case 162: // const_factor -> new_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 163: // const_factor -> default_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 164: // const_set -> tkSquareOpen, elem_list, tkSquareClose
{ 
			CurrentSemanticValue.ex = new pascal_set_constant(ValueStack[ValueStack.Depth-2].stn as expression_list, CurrentLocationSpan); 
		}
        break;
      case 165: // const_set -> tkVertParen, elem_list, tkVertParen
{ 
			CurrentSemanticValue.ex = new array_const_new(ValueStack[ValueStack.Depth-2].stn as expression_list, CurrentLocationSpan);  
		}
        break;
      case 166: // sign -> tkPlus
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 167: // sign -> tkMinus
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 168: // const_variable -> identifier
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 169: // const_variable -> literal
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 170: // const_variable -> unsigned_number
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 171: // const_variable -> tkInherited, identifier
{ 
			CurrentSemanticValue.ex = new inherited_ident(ValueStack[ValueStack.Depth-1].id.name, CurrentLocationSpan);
		}
        break;
      case 172: // const_variable -> sizeof_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 173: // const_variable -> typeof_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 174: // const_variable -> const_variable, const_variable_2
{
			CurrentSemanticValue.ex = NewConstVariable(ValueStack[ValueStack.Depth-2].ex, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);
        }
        break;
      case 175: // const_variable -> const_variable, tkAmpersend, template_type_params
{
			CurrentSemanticValue.ex = new ident_with_templateparams(ValueStack[ValueStack.Depth-3].ex as addressed_value, ValueStack[ValueStack.Depth-1].stn as template_param_list, CurrentLocationSpan);
        }
        break;
      case 176: // const_variable -> const_variable, tkSquareOpen, format_const_expr, 
                //                   tkSquareClose
{ 
    		var fe = ValueStack[ValueStack.Depth-2].ex as format_expr;
            if (!parsertools.build_tree_for_formatter)
            {
                if (fe.expr == null)
                    fe.expr = new int32_const(int.MaxValue,LocationStack[LocationStack.Depth-2]);
                if (fe.format1 == null)
                    fe.format1 = new int32_const(int.MaxValue,LocationStack[LocationStack.Depth-2]);
            }
    		CurrentSemanticValue.ex = new slice_expr(ValueStack[ValueStack.Depth-4].ex as addressed_value,fe.expr,fe.format1,fe.format2,CurrentLocationSpan);
		}
        break;
      case 177: // const_variable_2 -> tkPoint, identifier_or_keyword
{ 
			CurrentSemanticValue.ex = new dot_node(null, ValueStack[ValueStack.Depth-1].id as addressed_value, CurrentLocationSpan); 
		}
        break;
      case 178: // const_variable_2 -> tkDeref
{ 
			CurrentSemanticValue.ex = new roof_dereference();  
			CurrentSemanticValue.ex.source_context = CurrentLocationSpan;
		}
        break;
      case 179: // const_variable_2 -> tkRoundOpen, optional_const_func_expr_list, tkRoundClose
{ 
			CurrentSemanticValue.ex = new method_call(ValueStack[ValueStack.Depth-2].stn as expression_list, CurrentLocationSpan);  
		}
        break;
      case 180: // const_variable_2 -> tkSquareOpen, const_elem_list, tkSquareClose
{ 
			CurrentSemanticValue.ex = new indexer(ValueStack[ValueStack.Depth-2].stn as expression_list, CurrentLocationSpan);  
		}
        break;
      case 181: // optional_const_func_expr_list -> expr_list
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 182: // optional_const_func_expr_list -> /* empty */
{ CurrentSemanticValue.stn = null; }
        break;
      case 183: // const_elem_list -> const_elem_list1
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 185: // const_elem_list1 -> const_elem
{ 
			CurrentSemanticValue.stn = new expression_list(ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);
		}
        break;
      case 186: // const_elem_list1 -> const_elem_list1, tkComma, const_elem
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as expression_list).Add(ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);
		}
        break;
      case 187: // const_elem -> const_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 188: // const_elem -> const_expr, tkDotDot, const_expr
{ 
			CurrentSemanticValue.ex = new diapason_expr(ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan); 
		}
        break;
      case 189: // unsigned_number -> tkInteger
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 190: // unsigned_number -> tkHex
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 191: // unsigned_number -> tkFloat
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 192: // unsigned_number -> tkBigInteger
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 193: // typed_const -> const_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 194: // typed_const -> array_const
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 195: // typed_const -> record_const
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 196: // array_const -> tkRoundOpen, typed_const_list, tkRoundClose
{ 
			CurrentSemanticValue.ex = new array_const(ValueStack[ValueStack.Depth-2].stn as expression_list, CurrentLocationSpan); 
		}
        break;
      case 198: // typed_const_list -> typed_const_list1
{
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn;
		}
        break;
      case 199: // typed_const_list1 -> typed_const_plus
{ 
			CurrentSemanticValue.stn = new expression_list(ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);
        }
        break;
      case 200: // typed_const_list1 -> typed_const_list1, tkComma, typed_const_plus
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as expression_list).Add(ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);
		}
        break;
      case 201: // record_const -> tkRoundOpen, const_field_list, tkRoundClose
{
			CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-2].ex;
			CurrentSemanticValue.ex.source_context = CurrentLocationSpan;
		}
        break;
      case 202: // const_field_list -> const_field_list_1
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 203: // const_field_list -> const_field_list_1, tkSemiColon
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-2].ex; }
        break;
      case 204: // const_field_list_1 -> const_field
{ 
			CurrentSemanticValue.ex = new record_const(ValueStack[ValueStack.Depth-1].stn as record_const_definition, CurrentLocationSpan);
		}
        break;
      case 205: // const_field_list_1 -> const_field_list_1, tkSemiColon, const_field
{ 
			CurrentSemanticValue.ex = (ValueStack[ValueStack.Depth-3].ex as record_const).Add(ValueStack[ValueStack.Depth-1].stn as record_const_definition, CurrentLocationSpan);
		}
        break;
      case 206: // const_field -> const_field_name, tkColon, typed_const
{ 
			CurrentSemanticValue.stn = new record_const_definition(ValueStack[ValueStack.Depth-3].id, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan); 
		}
        break;
      case 207: // const_field_name -> identifier
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 208: // type_decl -> attribute_declarations, simple_type_decl
{  
			(ValueStack[ValueStack.Depth-1].stn as declaration).attributes = ValueStack[ValueStack.Depth-2].stn as attribute_list;
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn;
			CurrentSemanticValue.stn.source_context = LocationStack[LocationStack.Depth-1];
        }
        break;
      case 209: // attribute_declarations -> attribute_declaration
{ 
			CurrentSemanticValue.stn = new attribute_list(ValueStack[ValueStack.Depth-1].stn as simple_attribute_list, CurrentLocationSpan);
    }
        break;
      case 210: // attribute_declarations -> attribute_declarations, attribute_declaration
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-2].stn as attribute_list).Add(ValueStack[ValueStack.Depth-1].stn as simple_attribute_list, CurrentLocationSpan);
		}
        break;
      case 211: // attribute_declarations -> /* empty */
{ CurrentSemanticValue.stn = null; }
        break;
      case 212: // attribute_declaration -> tkSquareOpen, one_or_some_attribute, tkSquareClose
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-2].stn; }
        break;
      case 213: // one_or_some_attribute -> one_attribute
{ 
			CurrentSemanticValue.stn = new simple_attribute_list(ValueStack[ValueStack.Depth-1].stn as attribute, CurrentLocationSpan);
		}
        break;
      case 214: // one_or_some_attribute -> one_or_some_attribute, tkComma, one_attribute
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as simple_attribute_list).Add(ValueStack[ValueStack.Depth-1].stn as attribute, CurrentLocationSpan);
		}
        break;
      case 215: // one_attribute -> attribute_variable
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 216: // one_attribute -> identifier, tkColon, attribute_variable
{  
			(ValueStack[ValueStack.Depth-1].stn as attribute).qualifier = ValueStack[ValueStack.Depth-3].id;
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn;
			CurrentSemanticValue.stn.source_context = CurrentLocationSpan;
        }
        break;
      case 217: // simple_type_decl -> type_decl_identifier, tkEqual, type_decl_type, tkSemiColon
{ 
			CurrentSemanticValue.stn = new type_declaration(ValueStack[ValueStack.Depth-4].id, ValueStack[ValueStack.Depth-2].td, CurrentLocationSpan); 
		}
        break;
      case 218: // simple_type_decl -> template_identifier_with_equal, type_decl_type, tkSemiColon
{ 
			CurrentSemanticValue.stn = new type_declaration(ValueStack[ValueStack.Depth-3].id, ValueStack[ValueStack.Depth-2].td, CurrentLocationSpan); 
		}
        break;
      case 219: // type_decl_identifier -> identifier
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 220: // type_decl_identifier -> identifier, template_arguments
{ 
			CurrentSemanticValue.id = new template_type_name(ValueStack[ValueStack.Depth-2].id.name, ValueStack[ValueStack.Depth-1].stn as ident_list, CurrentLocationSpan); 
        }
        break;
      case 221: // template_identifier_with_equal -> identifier, tkLower, ident_list, 
                //                                   tkGreaterEqual
{ 
			CurrentSemanticValue.id = new template_type_name(ValueStack[ValueStack.Depth-4].id.name, ValueStack[ValueStack.Depth-2].stn as ident_list, CurrentLocationSpan); 
        }
        break;
      case 222: // type_decl_type -> type_ref
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 223: // type_decl_type -> object_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 224: // simple_type_question -> simple_type, tkQuestion
{
            if (parsertools.build_tree_for_formatter)
   			{
                CurrentSemanticValue.td = ValueStack[ValueStack.Depth-2].td;
            }
            else
            {
                var l = new List<ident>();
                l.Add(new ident("System"));
                l.Add(new ident("Nullable"));
                CurrentSemanticValue.td = new template_type_reference(new named_type_reference(l), new template_param_list(ValueStack[ValueStack.Depth-2].td), CurrentLocationSpan);
            }
		}
        break;
      case 225: // simple_type_question -> template_type, tkQuestion
{
            if (parsertools.build_tree_for_formatter)
   			{
                CurrentSemanticValue.td = ValueStack[ValueStack.Depth-2].td;
            }
            else
            {
                var l = new List<ident>();
                l.Add(new ident("System"));
                l.Add(new ident("Nullable"));
                CurrentSemanticValue.td = new template_type_reference(new named_type_reference(l), new template_param_list(ValueStack[ValueStack.Depth-2].td), CurrentLocationSpan);
            }
		}
        break;
      case 226: // type_ref -> simple_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 227: // type_ref -> simple_type_question
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 228: // type_ref -> string_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 229: // type_ref -> pointer_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 230: // type_ref -> structured_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 231: // type_ref -> procedural_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 232: // type_ref -> template_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 233: // template_type -> simple_type_identifier, template_type_params
{ 
			CurrentSemanticValue.td = new template_type_reference(ValueStack[ValueStack.Depth-2].td as named_type_reference, ValueStack[ValueStack.Depth-1].stn as template_param_list, CurrentLocationSpan); 
		}
        break;
      case 234: // template_type_params -> tkLower, template_param_list, tkGreater
{
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-2].stn;
			CurrentSemanticValue.stn.source_context = CurrentLocationSpan;
		}
        break;
      case 235: // template_type_empty_params -> tkNotEqual
{
            var ntr = new named_type_reference(new ident(""), CurrentLocationSpan);
            
			CurrentSemanticValue.stn = new template_param_list(ntr, CurrentLocationSpan);
            ntr.source_context = new SourceContext(CurrentSemanticValue.stn.source_context.end_position.line_num, CurrentSemanticValue.stn.source_context.end_position.column_num, CurrentSemanticValue.stn.source_context.begin_position.line_num, CurrentSemanticValue.stn.source_context.begin_position.column_num);
		}
        break;
      case 236: // template_type_empty_params -> tkLower, template_empty_param_list, tkGreater
{
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-2].stn;
			CurrentSemanticValue.stn.source_context = CurrentLocationSpan;
		}
        break;
      case 237: // template_param_list -> template_param
{ 
			CurrentSemanticValue.stn = new template_param_list(ValueStack[ValueStack.Depth-1].td, CurrentLocationSpan);
		}
        break;
      case 238: // template_param_list -> template_param_list, tkComma, template_param
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as template_param_list).Add(ValueStack[ValueStack.Depth-1].td, CurrentLocationSpan);
		}
        break;
      case 239: // template_empty_param_list -> template_empty_param
{ 
			CurrentSemanticValue.stn = new template_param_list(ValueStack[ValueStack.Depth-1].td, CurrentLocationSpan);
		}
        break;
      case 240: // template_empty_param_list -> template_empty_param_list, tkComma, 
                //                              template_empty_param
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as template_param_list).Add(ValueStack[ValueStack.Depth-1].td, CurrentLocationSpan);
		}
        break;
      case 241: // template_empty_param -> /* empty */
{ 
            CurrentSemanticValue.td = new named_type_reference(new ident(""), CurrentLocationSpan);
        }
        break;
      case 242: // template_param -> simple_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 243: // template_param -> simple_type, tkQuestion
{
            if (parsertools.build_tree_for_formatter)
   			{
                CurrentSemanticValue.td = ValueStack[ValueStack.Depth-2].td;
            }
            else
            {
                var l = new List<ident>();
                l.Add(new ident("System"));
                l.Add(new ident("Nullable"));
                CurrentSemanticValue.td = new template_type_reference(new named_type_reference(l), new template_param_list(ValueStack[ValueStack.Depth-2].td), CurrentLocationSpan);
            }
		}
        break;
      case 244: // template_param -> structured_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 245: // template_param -> procedural_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 246: // template_param -> template_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 247: // simple_type -> range_expr
{
	    	CurrentSemanticValue.td = parsertools.ConvertDotNodeOrIdentToNamedTypeReference(ValueStack[ValueStack.Depth-1].ex); 
	    }
        break;
      case 248: // simple_type -> range_expr, tkDotDot, range_expr
{ 
			CurrentSemanticValue.td = new diapason(ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan); 
		}
        break;
      case 249: // simple_type -> tkRoundOpen, enumeration_id_list, tkRoundClose
{ 
			CurrentSemanticValue.td = new enum_type_definition(ValueStack[ValueStack.Depth-2].stn as enumerator_list, CurrentLocationSpan);  
		}
        break;
      case 250: // range_expr -> range_term
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 251: // range_expr -> range_expr, const_addop, range_term
{ 
			CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan); 
		}
        break;
      case 252: // range_term -> range_factor
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 253: // range_term -> range_term, const_mulop, range_factor
{ 
			CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan); 
		}
        break;
      case 254: // range_factor -> simple_type_identifier
{ 
			CurrentSemanticValue.ex = parsertools.ConvertNamedTypeReferenceToDotNodeOrIdent(ValueStack[ValueStack.Depth-1].td as named_type_reference);
        }
        break;
      case 255: // range_factor -> unsigned_number
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 256: // range_factor -> sign, range_factor
{ 
			CurrentSemanticValue.ex = new un_expr(ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan); 
		}
        break;
      case 257: // range_factor -> literal
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 258: // range_factor -> range_factor, tkRoundOpen, const_elem_list, tkRoundClose
{ 
			CurrentSemanticValue.ex = new method_call(ValueStack[ValueStack.Depth-4].ex as addressed_value, ValueStack[ValueStack.Depth-2].stn as expression_list, CurrentLocationSpan);
        }
        break;
      case 259: // simple_type_identifier -> identifier
{ 
			CurrentSemanticValue.td = new named_type_reference(ValueStack[ValueStack.Depth-1].id, CurrentLocationSpan);
		}
        break;
      case 260: // simple_type_identifier -> simple_type_identifier, tkPoint, 
                //                           identifier_or_keyword
{ 
			CurrentSemanticValue.td = (ValueStack[ValueStack.Depth-3].td as named_type_reference).Add(ValueStack[ValueStack.Depth-1].id, CurrentLocationSpan);
		}
        break;
      case 261: // enumeration_id_list -> enumeration_id, tkComma, enumeration_id
{ 
			CurrentSemanticValue.stn = new enumerator_list(ValueStack[ValueStack.Depth-3].stn as enumerator, CurrentLocationSpan);
			(CurrentSemanticValue.stn as enumerator_list).Add(ValueStack[ValueStack.Depth-1].stn as enumerator, CurrentLocationSpan);
        }
        break;
      case 262: // enumeration_id_list -> enumeration_id_list, tkComma, enumeration_id
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as enumerator_list).Add(ValueStack[ValueStack.Depth-1].stn as enumerator, CurrentLocationSpan);
        }
        break;
      case 263: // enumeration_id -> type_ref
{ 
			CurrentSemanticValue.stn = new enumerator(ValueStack[ValueStack.Depth-1].td, null, CurrentLocationSpan); 
		}
        break;
      case 264: // enumeration_id -> type_ref, tkEqual, expr
{ 
			CurrentSemanticValue.stn = new enumerator(ValueStack[ValueStack.Depth-3].td, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan); 
		}
        break;
      case 265: // pointer_type -> tkDeref, fptype
{ 
			CurrentSemanticValue.td = new ref_type(ValueStack[ValueStack.Depth-1].td,CurrentLocationSpan);
		}
        break;
      case 266: // structured_type -> unpacked_structured_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 267: // structured_type -> tkPacked, unpacked_structured_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 268: // unpacked_structured_type -> array_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 269: // unpacked_structured_type -> record_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 270: // unpacked_structured_type -> set_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 271: // unpacked_structured_type -> file_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 272: // unpacked_structured_type -> sequence_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 273: // sequence_type -> tkSequence, tkOf, type_ref
{
			CurrentSemanticValue.td = new sequence_type(ValueStack[ValueStack.Depth-1].td,CurrentLocationSpan);
		}
        break;
      case 274: // array_type -> tkArray, tkSquareOpen, simple_type_list, tkSquareClose, tkOf, 
                //               type_ref
{ 
			CurrentSemanticValue.td = new array_type(ValueStack[ValueStack.Depth-4].stn as indexers_types, ValueStack[ValueStack.Depth-1].td, CurrentLocationSpan); 
        }
        break;
      case 275: // array_type -> unsized_array_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 276: // unsized_array_type -> tkArray, tkOf, type_ref
{ 
			CurrentSemanticValue.td = new array_type(null, ValueStack[ValueStack.Depth-1].td, CurrentLocationSpan); 
        }
        break;
      case 277: // simple_type_list -> simple_type_or_
{ 
			CurrentSemanticValue.stn = new indexers_types(ValueStack[ValueStack.Depth-1].td, CurrentLocationSpan);
        }
        break;
      case 278: // simple_type_list -> simple_type_list, tkComma, simple_type_or_
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as indexers_types).Add(ValueStack[ValueStack.Depth-1].td, CurrentLocationSpan);
        }
        break;
      case 279: // simple_type_or_ -> simple_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 280: // simple_type_or_ -> /* empty */
{ CurrentSemanticValue.td = null; }
        break;
      case 281: // set_type -> tkSet, tkOf, type_ref
{ 
			CurrentSemanticValue.td = new set_type_definition(ValueStack[ValueStack.Depth-1].td, CurrentLocationSpan); 
		}
        break;
      case 282: // file_type -> tkFile, tkOf, type_ref
{ 
			CurrentSemanticValue.td = new file_type(ValueStack[ValueStack.Depth-1].td, CurrentLocationSpan);
		}
        break;
      case 283: // file_type -> tkFile
{ 
			CurrentSemanticValue.td = new file_type();  
			CurrentSemanticValue.td.source_context = CurrentLocationSpan;
		}
        break;
      case 284: // string_type -> tkIdentifier, tkSquareOpen, const_expr, tkSquareClose
{ 
			CurrentSemanticValue.td = new string_num_definition(ValueStack[ValueStack.Depth-2].ex, ValueStack[ValueStack.Depth-4].id, CurrentLocationSpan);
		}
        break;
      case 285: // procedural_type -> procedural_type_kind
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 286: // procedural_type_kind -> proc_type_decl
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 287: // proc_type_decl -> tkProcedure, fp_list
{ 
			CurrentSemanticValue.td = new procedure_header(ValueStack[ValueStack.Depth-1].stn as formal_parameters,null,null,false,false,null,null,CurrentLocationSpan);
        }
        break;
      case 288: // proc_type_decl -> tkFunction, fp_list, tkColon, fptype
{ 
			CurrentSemanticValue.td = new function_header(ValueStack[ValueStack.Depth-3].stn as formal_parameters, null, null, null, ValueStack[ValueStack.Depth-1].td as type_definition, CurrentLocationSpan);
        }
        break;
      case 289: // proc_type_decl -> simple_type_identifier, tkArrow, template_param
{
    		CurrentSemanticValue.td = new modern_proc_type(ValueStack[ValueStack.Depth-3].td,null,ValueStack[ValueStack.Depth-1].td,CurrentLocationSpan);            
    	}
        break;
      case 290: // proc_type_decl -> template_type, tkArrow, template_param
{
    		CurrentSemanticValue.td = new modern_proc_type(ValueStack[ValueStack.Depth-3].td,null,ValueStack[ValueStack.Depth-1].td,CurrentLocationSpan);            
    	}
        break;
      case 291: // proc_type_decl -> tkRoundOpen, tkRoundClose, tkArrow, template_param
{
    		CurrentSemanticValue.td = new modern_proc_type(null,null,ValueStack[ValueStack.Depth-1].td,CurrentLocationSpan);
    	}
        break;
      case 292: // proc_type_decl -> tkRoundOpen, enumeration_id_list, tkRoundClose, tkArrow, 
                //                   template_param
{
    		CurrentSemanticValue.td = new modern_proc_type(null,ValueStack[ValueStack.Depth-4].stn as enumerator_list,ValueStack[ValueStack.Depth-1].td,CurrentLocationSpan);
    	}
        break;
      case 293: // proc_type_decl -> simple_type_identifier, tkArrow, tkRoundOpen, tkRoundClose
{
    		CurrentSemanticValue.td = new modern_proc_type(ValueStack[ValueStack.Depth-4].td,null,null,CurrentLocationSpan);
    	}
        break;
      case 294: // proc_type_decl -> template_type, tkArrow, tkRoundOpen, tkRoundClose
{
    		CurrentSemanticValue.td = new modern_proc_type(ValueStack[ValueStack.Depth-4].td,null,null,CurrentLocationSpan);
    	}
        break;
      case 295: // proc_type_decl -> tkRoundOpen, tkRoundClose, tkArrow, tkRoundOpen, tkRoundClose
{
    		CurrentSemanticValue.td = new modern_proc_type(null,null,null,CurrentLocationSpan);
    	}
        break;
      case 296: // proc_type_decl -> tkRoundOpen, enumeration_id_list, tkRoundClose, tkArrow, 
                //                   tkRoundOpen, tkRoundClose
{
    		CurrentSemanticValue.td = new modern_proc_type(null,ValueStack[ValueStack.Depth-5].stn as enumerator_list,null,CurrentLocationSpan);
    	}
        break;
      case 297: // object_type -> class_attributes, class_or_interface_keyword, 
                //                optional_base_classes, optional_where_section, 
                //                optional_component_list_seq_end
{ 
            var cd = NewObjectType((class_attribute)ValueStack[ValueStack.Depth-5].ob, ValueStack[ValueStack.Depth-4].ti, ValueStack[ValueStack.Depth-3].stn as named_type_reference_list, ValueStack[ValueStack.Depth-2].stn as where_definition_list, ValueStack[ValueStack.Depth-1].stn as class_body_list, CurrentLocationSpan); 
			CurrentSemanticValue.td = cd;
		}
        break;
      case 298: // record_type -> tkRecord, optional_base_classes, optional_where_section, 
                //                member_list_section, tkEnd
{ 
			var nnrt = new class_definition(ValueStack[ValueStack.Depth-4].stn as named_type_reference_list, ValueStack[ValueStack.Depth-2].stn as class_body_list, class_keyword.Record, null, ValueStack[ValueStack.Depth-3].stn as where_definition_list, class_attribute.None, false, CurrentLocationSpan); 
			if (/*nnrt.body!=null && nnrt.body.class_def_blocks!=null && 
				nnrt.body.class_def_blocks.Count>0 &&*/ 
				nnrt.body.class_def_blocks[0].access_mod==null)
			{
                nnrt.body.class_def_blocks[0].access_mod = new access_modifer_node(access_modifer.public_modifer);
			}        
			CurrentSemanticValue.td = nnrt;
		}
        break;
      case 299: // class_attribute -> tkSealed
{ CurrentSemanticValue.ob = class_attribute.Sealed; }
        break;
      case 300: // class_attribute -> tkPartial
{ CurrentSemanticValue.ob = class_attribute.Partial; }
        break;
      case 301: // class_attribute -> tkAbstract
{ CurrentSemanticValue.ob = class_attribute.Abstract; }
        break;
      case 302: // class_attribute -> tkAuto
{ CurrentSemanticValue.ob = class_attribute.Auto; }
        break;
      case 303: // class_attribute -> tkStatic
{ CurrentSemanticValue.ob = class_attribute.Static; }
        break;
      case 304: // class_attributes -> /* empty */
{ 
			CurrentSemanticValue.ob = class_attribute.None; 
		}
        break;
      case 305: // class_attributes -> class_attributes1
{
			CurrentSemanticValue.ob = ValueStack[ValueStack.Depth-1].ob;
		}
        break;
      case 306: // class_attributes1 -> class_attribute
{
			CurrentSemanticValue.ob = ValueStack[ValueStack.Depth-1].ob;
		}
        break;
      case 307: // class_attributes1 -> class_attributes1, class_attribute
{
            if (((class_attribute)ValueStack[ValueStack.Depth-2].ob & (class_attribute)ValueStack[ValueStack.Depth-1].ob) == (class_attribute)ValueStack[ValueStack.Depth-1].ob)
                parsertools.AddErrorFromResource("ATTRIBUTE_REDECLARED",LocationStack[LocationStack.Depth-1]);
			CurrentSemanticValue.ob  = ((class_attribute)ValueStack[ValueStack.Depth-2].ob) | ((class_attribute)ValueStack[ValueStack.Depth-1].ob);
			//$$ = $1;
		}
        break;
      case 308: // class_or_interface_keyword -> tkClass
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 309: // class_or_interface_keyword -> tkInterface
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 310: // class_or_interface_keyword -> tkTemplate
{ 
			CurrentSemanticValue.ti = NewClassOrInterfaceKeyword(ValueStack[ValueStack.Depth-1].ti);
		}
        break;
      case 311: // class_or_interface_keyword -> tkTemplate, tkClass
{ 
			CurrentSemanticValue.ti = NewClassOrInterfaceKeyword(ValueStack[ValueStack.Depth-2].ti, "c", CurrentLocationSpan);
		}
        break;
      case 312: // class_or_interface_keyword -> tkTemplate, tkRecord
{ 
			CurrentSemanticValue.ti = NewClassOrInterfaceKeyword(ValueStack[ValueStack.Depth-2].ti, "r", CurrentLocationSpan);
		}
        break;
      case 313: // class_or_interface_keyword -> tkTemplate, tkInterface
{ 
			CurrentSemanticValue.ti = NewClassOrInterfaceKeyword(ValueStack[ValueStack.Depth-2].ti, "i", CurrentLocationSpan);
		}
        break;
      case 314: // optional_component_list_seq_end -> /* empty */
{ CurrentSemanticValue.stn = null; }
        break;
      case 315: // optional_component_list_seq_end -> member_list_section, tkEnd
{
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-2].stn;
			CurrentSemanticValue.stn.source_context = CurrentLocationSpan;
		}
        break;
      case 317: // optional_base_classes -> tkRoundOpen, base_classes_names_list, tkRoundClose
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-2].stn; }
        break;
      case 318: // base_classes_names_list -> base_class_name
{ 
			CurrentSemanticValue.stn = new named_type_reference_list(ValueStack[ValueStack.Depth-1].stn as named_type_reference, CurrentLocationSpan);
		}
        break;
      case 319: // base_classes_names_list -> base_classes_names_list, tkComma, base_class_name
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as named_type_reference_list).Add(ValueStack[ValueStack.Depth-1].stn as named_type_reference, CurrentLocationSpan);
		}
        break;
      case 320: // base_class_name -> simple_type_identifier
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 321: // base_class_name -> template_type
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 322: // template_arguments -> tkLower, ident_list, tkGreater
{
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-2].stn;
			CurrentSemanticValue.stn.source_context = CurrentLocationSpan;
		}
        break;
      case 323: // optional_where_section -> /* empty */
{ CurrentSemanticValue.stn = null; }
        break;
      case 324: // optional_where_section -> where_part_list
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 325: // where_part_list -> where_part
{ 
			CurrentSemanticValue.stn = new where_definition_list(ValueStack[ValueStack.Depth-1].stn as where_definition, CurrentLocationSpan);
		}
        break;
      case 326: // where_part_list -> where_part_list, where_part
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-2].stn as where_definition_list).Add(ValueStack[ValueStack.Depth-1].stn as where_definition, CurrentLocationSpan);
		}
        break;
      case 327: // where_part -> tkWhere, ident_list, tkColon, type_ref_and_secific_list, 
                //               tkSemiColon
{ 
			CurrentSemanticValue.stn = new where_definition(ValueStack[ValueStack.Depth-4].stn as ident_list, ValueStack[ValueStack.Depth-2].stn as where_type_specificator_list, CurrentLocationSpan); 
		}
        break;
      case 328: // type_ref_and_secific_list -> type_ref_or_secific
{ 
			CurrentSemanticValue.stn = new where_type_specificator_list(ValueStack[ValueStack.Depth-1].td, CurrentLocationSpan);
		}
        break;
      case 329: // type_ref_and_secific_list -> type_ref_and_secific_list, tkComma, 
                //                              type_ref_or_secific
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as where_type_specificator_list).Add(ValueStack[ValueStack.Depth-1].td, CurrentLocationSpan);
		}
        break;
      case 330: // type_ref_or_secific -> type_ref
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 331: // type_ref_or_secific -> tkClass
{ 
			CurrentSemanticValue.td = new declaration_specificator(DeclarationSpecificator.WhereDefClass, ValueStack[ValueStack.Depth-1].ti.text, CurrentLocationSpan); 
		}
        break;
      case 332: // type_ref_or_secific -> tkRecord
{ 
			CurrentSemanticValue.td = new declaration_specificator(DeclarationSpecificator.WhereDefValueType, ValueStack[ValueStack.Depth-1].ti.text, CurrentLocationSpan); 
		}
        break;
      case 333: // type_ref_or_secific -> tkConstructor
{ 
			CurrentSemanticValue.td = new declaration_specificator(DeclarationSpecificator.WhereDefConstructor, ValueStack[ValueStack.Depth-1].ti.text, CurrentLocationSpan); 
		}
        break;
      case 334: // member_list_section -> member_list
{ 
			CurrentSemanticValue.stn = new class_body_list(ValueStack[ValueStack.Depth-1].stn as class_members, CurrentLocationSpan);
        }
        break;
      case 335: // member_list_section -> member_list_section, ot_visibility_specifier, 
                //                        member_list
{ 
		    (ValueStack[ValueStack.Depth-1].stn as class_members).access_mod = ValueStack[ValueStack.Depth-2].stn as access_modifer_node;
			(ValueStack[ValueStack.Depth-3].stn as class_body_list).Add(ValueStack[ValueStack.Depth-1].stn as class_members,CurrentLocationSpan);
			
			if ((ValueStack[ValueStack.Depth-3].stn as class_body_list).class_def_blocks[0].Count == 0)
                (ValueStack[ValueStack.Depth-3].stn as class_body_list).class_def_blocks.RemoveAt(0);
			
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-3].stn;
        }
        break;
      case 336: // ot_visibility_specifier -> tkInternal
{ CurrentSemanticValue.stn = new access_modifer_node(access_modifer.internal_modifer, CurrentLocationSpan); }
        break;
      case 337: // ot_visibility_specifier -> tkPublic
{ CurrentSemanticValue.stn = new access_modifer_node(access_modifer.public_modifer, CurrentLocationSpan); }
        break;
      case 338: // ot_visibility_specifier -> tkProtected
{ CurrentSemanticValue.stn = new access_modifer_node(access_modifer.protected_modifer, CurrentLocationSpan); }
        break;
      case 339: // ot_visibility_specifier -> tkPrivate
{ CurrentSemanticValue.stn = new access_modifer_node(access_modifer.private_modifer, CurrentLocationSpan); }
        break;
      case 340: // member_list -> /* empty */
{ CurrentSemanticValue.stn = new class_members(); }
        break;
      case 341: // member_list -> field_or_const_definition_list, optional_semicolon
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-2].stn; }
        break;
      case 342: // member_list -> method_decl_list
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 343: // member_list -> field_or_const_definition_list, tkSemiColon, method_decl_list
{  
			(ValueStack[ValueStack.Depth-3].stn as class_members).members.AddRange((ValueStack[ValueStack.Depth-1].stn as class_members).members);
			(ValueStack[ValueStack.Depth-3].stn as class_members).source_context = CurrentLocationSpan;
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-3].stn;
        }
        break;
      case 344: // ident_list -> identifier
{ 
			CurrentSemanticValue.stn = new ident_list(ValueStack[ValueStack.Depth-1].id, CurrentLocationSpan);
		}
        break;
      case 345: // ident_list -> ident_list, tkComma, identifier
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as ident_list).Add(ValueStack[ValueStack.Depth-1].id, CurrentLocationSpan);
		}
        break;
      case 346: // optional_semicolon -> /* empty */
{ CurrentSemanticValue.ob = null; }
        break;
      case 347: // optional_semicolon -> tkSemiColon
{ CurrentSemanticValue.ob = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 348: // field_or_const_definition_list -> field_or_const_definition
{ 
			CurrentSemanticValue.stn = new class_members(ValueStack[ValueStack.Depth-1].stn as declaration, CurrentLocationSpan);
        }
        break;
      case 349: // field_or_const_definition_list -> field_or_const_definition_list, tkSemiColon, 
                //                                   field_or_const_definition
{   
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as class_members).Add(ValueStack[ValueStack.Depth-1].stn as declaration, CurrentLocationSpan);
        }
        break;
      case 350: // field_or_const_definition -> attribute_declarations, 
                //                              simple_field_or_const_definition
{  
		    (ValueStack[ValueStack.Depth-1].stn as declaration).attributes = ValueStack[ValueStack.Depth-2].stn as attribute_list;
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn;
        }
        break;
      case 351: // method_decl_list -> method_or_property_decl
{ 
			CurrentSemanticValue.stn = new class_members(ValueStack[ValueStack.Depth-1].stn as declaration, CurrentLocationSpan);
        }
        break;
      case 352: // method_decl_list -> method_decl_list, method_or_property_decl
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-2].stn as class_members).Add(ValueStack[ValueStack.Depth-1].stn as declaration, CurrentLocationSpan);
        }
        break;
      case 353: // method_or_property_decl -> method_decl_withattr
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 354: // method_or_property_decl -> property_definition
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 355: // simple_field_or_const_definition -> tkConst, only_const_decl
{ 
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn;
			CurrentSemanticValue.stn.source_context = CurrentLocationSpan;
		}
        break;
      case 356: // simple_field_or_const_definition -> field_definition
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 357: // simple_field_or_const_definition -> class_or_static, field_definition
{ 
			(ValueStack[ValueStack.Depth-1].stn as var_def_statement).var_attr = definition_attribute.Static;
			(ValueStack[ValueStack.Depth-1].stn as var_def_statement).source_context = CurrentLocationSpan;
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn;
        }
        break;
      case 358: // class_or_static -> tkStatic
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 359: // class_or_static -> tkClass
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 360: // field_definition -> var_decl_part
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 361: // field_definition -> tkEvent, ident_list, tkColon, type_ref
{ 
			CurrentSemanticValue.stn = new var_def_statement(ValueStack[ValueStack.Depth-3].stn as ident_list, ValueStack[ValueStack.Depth-1].td, null, definition_attribute.None, true, CurrentLocationSpan); 
        }
        break;
      case 362: // method_decl_withattr -> attribute_declarations, method_header
{  
			(ValueStack[ValueStack.Depth-1].td as declaration).attributes = ValueStack[ValueStack.Depth-2].stn as attribute_list;
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].td;
        }
        break;
      case 363: // method_decl_withattr -> attribute_declarations, method_decl
{  
			(ValueStack[ValueStack.Depth-1].stn as declaration).attributes = ValueStack[ValueStack.Depth-2].stn as attribute_list;
            if (ValueStack[ValueStack.Depth-1].stn is procedure_definition && (ValueStack[ValueStack.Depth-1].stn as procedure_definition).proc_header != null)
                (ValueStack[ValueStack.Depth-1].stn as procedure_definition).proc_header.attributes = ValueStack[ValueStack.Depth-2].stn as attribute_list;
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn;
     }
        break;
      case 364: // method_decl -> inclass_proc_func_decl
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 365: // method_decl -> inclass_constr_destr_decl
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 366: // method_header -> class_or_static, method_procfunc_header
{ 
			(ValueStack[ValueStack.Depth-1].td as procedure_header).class_keyword = true;
			CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td;
		}
        break;
      case 367: // method_header -> method_procfunc_header
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 368: // method_header -> constr_destr_header
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 369: // method_procfunc_header -> proc_func_header
{ 
			CurrentSemanticValue.td = NewProcfuncHeading(ValueStack[ValueStack.Depth-1].td as procedure_header);
		}
        break;
      case 370: // proc_func_header -> proc_header
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 371: // proc_func_header -> func_header
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 372: // constr_destr_header -> tkConstructor, optional_proc_name, fp_list, 
                //                        optional_method_modificators
{ 
			CurrentSemanticValue.td = new constructor(null,ValueStack[ValueStack.Depth-2].stn as formal_parameters,ValueStack[ValueStack.Depth-1].stn as procedure_attributes_list,ValueStack[ValueStack.Depth-3].stn as method_name,false,false,null,null,CurrentLocationSpan);
        }
        break;
      case 373: // constr_destr_header -> class_or_static, tkConstructor, optional_proc_name, 
                //                        fp_list, optional_method_modificators
{ 
			CurrentSemanticValue.td = new constructor(null,ValueStack[ValueStack.Depth-2].stn as formal_parameters,ValueStack[ValueStack.Depth-1].stn as procedure_attributes_list,ValueStack[ValueStack.Depth-3].stn as method_name,false,true,null,null,CurrentLocationSpan);
        }
        break;
      case 374: // constr_destr_header -> tkDestructor, optional_proc_name, fp_list, 
                //                        optional_method_modificators
{ 
			CurrentSemanticValue.td = new destructor(null,ValueStack[ValueStack.Depth-2].stn as formal_parameters,ValueStack[ValueStack.Depth-1].stn as procedure_attributes_list,ValueStack[ValueStack.Depth-3].stn as method_name, false,false,null,null,CurrentLocationSpan);
        }
        break;
      case 375: // optional_proc_name -> proc_name
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 376: // optional_proc_name -> /* empty */
{ CurrentSemanticValue.stn = null; }
        break;
      case 377: // property_definition -> attribute_declarations, simple_property_definition
{  
			CurrentSemanticValue.stn = NewPropertyDefinition(ValueStack[ValueStack.Depth-2].stn as attribute_list, ValueStack[ValueStack.Depth-1].stn as declaration, LocationStack[LocationStack.Depth-1]);
        }
        break;
      case 378: // simple_property_definition -> tkProperty, func_name, property_interface, 
                //                               property_specifiers, tkSemiColon, 
                //                               array_defaultproperty
{ 
			CurrentSemanticValue.stn = NewSimplePropertyDefinition(ValueStack[ValueStack.Depth-5].stn as method_name, ValueStack[ValueStack.Depth-4].stn as property_interface, ValueStack[ValueStack.Depth-3].stn as property_accessors, proc_attribute.attr_none, ValueStack[ValueStack.Depth-1].stn as property_array_default, CurrentLocationSpan);
        }
        break;
      case 379: // simple_property_definition -> tkProperty, func_name, property_interface, 
                //                               property_specifiers, tkSemiColon, 
                //                               property_modificator, tkSemiColon, 
                //                               array_defaultproperty
{ 
            proc_attribute pa = proc_attribute.attr_none;
            if (ValueStack[ValueStack.Depth-3].id.name.ToLower() == "virtual")
               	pa = proc_attribute.attr_virtual;
 			else if (ValueStack[ValueStack.Depth-3].id.name.ToLower() == "override") 
 			    pa = proc_attribute.attr_override;
            else if (ValueStack[ValueStack.Depth-3].id.name.ToLower() == "abstract") 
 			    pa = proc_attribute.attr_abstract;
			CurrentSemanticValue.stn = NewSimplePropertyDefinition(ValueStack[ValueStack.Depth-7].stn as method_name, ValueStack[ValueStack.Depth-6].stn as property_interface, ValueStack[ValueStack.Depth-5].stn as property_accessors, pa, ValueStack[ValueStack.Depth-1].stn as property_array_default, CurrentLocationSpan);
        }
        break;
      case 380: // simple_property_definition -> class_or_static, tkProperty, func_name, 
                //                               property_interface, property_specifiers, 
                //                               tkSemiColon, array_defaultproperty
{ 
			CurrentSemanticValue.stn = NewSimplePropertyDefinition(ValueStack[ValueStack.Depth-5].stn as method_name, ValueStack[ValueStack.Depth-4].stn as property_interface, ValueStack[ValueStack.Depth-3].stn as property_accessors, proc_attribute.attr_none, ValueStack[ValueStack.Depth-1].stn as property_array_default, CurrentLocationSpan);
        	(CurrentSemanticValue.stn as simple_property).attr = definition_attribute.Static;
        }
        break;
      case 381: // simple_property_definition -> class_or_static, tkProperty, func_name, 
                //                               property_interface, property_specifiers, 
                //                               tkSemiColon, property_modificator, tkSemiColon, 
                //                               array_defaultproperty
{ 
			parsertools.AddErrorFromResource("STATIC_PROPERTIES_CANNOT_HAVE_ATTRBUTE_{0}",LocationStack[LocationStack.Depth-3],ValueStack[ValueStack.Depth-3].id.name);        	
        }
        break;
      case 382: // simple_property_definition -> tkAuto, tkProperty, func_name, property_interface, 
                //                               optional_property_initialization, tkSemiColon
{
			CurrentSemanticValue.stn = NewSimplePropertyDefinition(ValueStack[ValueStack.Depth-4].stn as method_name, ValueStack[ValueStack.Depth-3].stn as property_interface, null, proc_attribute.attr_none, null, CurrentLocationSpan);
			(CurrentSemanticValue.stn as simple_property).is_auto = true;
			(CurrentSemanticValue.stn as simple_property).initial_value = ValueStack[ValueStack.Depth-2].ex;
		}
        break;
      case 383: // simple_property_definition -> class_or_static, tkAuto, tkProperty, func_name, 
                //                               property_interface, 
                //                               optional_property_initialization, tkSemiColon
{
			CurrentSemanticValue.stn = NewSimplePropertyDefinition(ValueStack[ValueStack.Depth-4].stn as method_name, ValueStack[ValueStack.Depth-3].stn as property_interface, null, proc_attribute.attr_none, null, CurrentLocationSpan);
			(CurrentSemanticValue.stn as simple_property).is_auto = true;
			(CurrentSemanticValue.stn as simple_property).attr = definition_attribute.Static;
			(CurrentSemanticValue.stn as simple_property).initial_value = ValueStack[ValueStack.Depth-2].ex;
		}
        break;
      case 384: // optional_property_initialization -> tkAssign, expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 385: // optional_property_initialization -> /* empty */
{ CurrentSemanticValue.ex = null; }
        break;
      case 386: // array_defaultproperty -> /* empty */
{ CurrentSemanticValue.stn = null; }
        break;
      case 387: // array_defaultproperty -> tkDefault, tkSemiColon
{ 
			CurrentSemanticValue.stn = new property_array_default();  
			CurrentSemanticValue.stn.source_context = CurrentLocationSpan;
		}
        break;
      case 388: // property_interface -> property_parameter_list, tkColon, fptype
{ 
			CurrentSemanticValue.stn = new property_interface(ValueStack[ValueStack.Depth-3].stn as property_parameter_list, ValueStack[ValueStack.Depth-1].td, null, CurrentLocationSpan);
        }
        break;
      case 389: // property_parameter_list -> /* empty */
{ CurrentSemanticValue.stn = null; }
        break;
      case 390: // property_parameter_list -> tkSquareOpen, parameter_decl_list, tkSquareClose
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-2].stn; }
        break;
      case 391: // parameter_decl_list -> parameter_decl
{ 
			CurrentSemanticValue.stn = new property_parameter_list(ValueStack[ValueStack.Depth-1].stn as property_parameter, CurrentLocationSpan);
		}
        break;
      case 392: // parameter_decl_list -> parameter_decl_list, tkSemiColon, parameter_decl
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as property_parameter_list).Add(ValueStack[ValueStack.Depth-1].stn as property_parameter, CurrentLocationSpan);
		}
        break;
      case 393: // parameter_decl -> ident_list, tkColon, fptype
{ 
			CurrentSemanticValue.stn = new property_parameter(ValueStack[ValueStack.Depth-3].stn as ident_list, ValueStack[ValueStack.Depth-1].td, CurrentLocationSpan); 
		}
        break;
      case 394: // optional_read_expr -> expr_with_func_decl_lambda
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 395: // optional_read_expr -> /* empty */
{ CurrentSemanticValue.ex = null; }
        break;
      case 397: // property_specifiers -> tkRead, optional_read_expr, write_property_specifiers
{ 
        	if (ValueStack[ValueStack.Depth-2].ex == null || ValueStack[ValueStack.Depth-2].ex is ident) // ����������� ��������
        	{
        		CurrentSemanticValue.stn = NewPropertySpecifiersRead(ValueStack[ValueStack.Depth-3].id, ValueStack[ValueStack.Depth-2].ex as ident, null, null, ValueStack[ValueStack.Depth-1].stn as property_accessors, CurrentLocationSpan);
        	}
        	else // ����������� ��������
        	{
				var id = NewId("#GetGen", LocationStack[LocationStack.Depth-2]);
                procedure_definition pr = null;
                if (!parsertools.build_tree_for_formatter)
                    pr = CreateAndAddToClassReadFunc(ValueStack[ValueStack.Depth-2].ex, id, LocationStack[LocationStack.Depth-2]);
				CurrentSemanticValue.stn = NewPropertySpecifiersRead(ValueStack[ValueStack.Depth-3].id, id, pr, ValueStack[ValueStack.Depth-2].ex, ValueStack[ValueStack.Depth-1].stn as property_accessors, CurrentLocationSpan); // $2 ��������� ��� �������������� 
			}
        }
        break;
      case 398: // property_specifiers -> tkWrite, unlabelled_stmt, read_property_specifiers
{ 
        	if (ValueStack[ValueStack.Depth-2].stn is empty_statement)
        	{
        	
        		CurrentSemanticValue.stn = NewPropertySpecifiersWrite(ValueStack[ValueStack.Depth-3].id, null, null, null, ValueStack[ValueStack.Depth-1].stn as property_accessors, CurrentLocationSpan);
        	}
        	else if (ValueStack[ValueStack.Depth-2].stn is procedure_call && (ValueStack[ValueStack.Depth-2].stn as procedure_call).is_ident) // ����������� ��������
        	{
        	
        		CurrentSemanticValue.stn = NewPropertySpecifiersWrite(ValueStack[ValueStack.Depth-3].id, (ValueStack[ValueStack.Depth-2].stn as procedure_call).func_name as ident, null, null, ValueStack[ValueStack.Depth-1].stn as property_accessors, CurrentLocationSpan);  // ������ �������� - � ���������������
        	}
        	else // ����������� ��������
        	{
				var id = NewId("#SetGen", LocationStack[LocationStack.Depth-2]);
                procedure_definition pr = null;
                if (!parsertools.build_tree_for_formatter)
                    pr = CreateAndAddToClassWriteProc(ValueStack[ValueStack.Depth-2].stn as statement,id,LocationStack[LocationStack.Depth-2]);
                if (parsertools.build_tree_for_formatter)
					CurrentSemanticValue.stn = NewPropertySpecifiersWrite(ValueStack[ValueStack.Depth-3].id, id, pr, ValueStack[ValueStack.Depth-2].stn as statement, ValueStack[ValueStack.Depth-1].stn as property_accessors, CurrentLocationSpan); // $2 ��������� ��� ��������������
				else CurrentSemanticValue.stn = NewPropertySpecifiersWrite(ValueStack[ValueStack.Depth-3].id, id, pr, null, ValueStack[ValueStack.Depth-1].stn as property_accessors, CurrentLocationSpan); 	
			}
        }
        break;
      case 400: // write_property_specifiers -> tkWrite, unlabelled_stmt
{ 
        	if (ValueStack[ValueStack.Depth-1].stn is empty_statement)
        	{
        	
        		CurrentSemanticValue.stn = NewPropertySpecifiersWrite(ValueStack[ValueStack.Depth-2].id, null, null, null, null, CurrentLocationSpan);
        	}
        	else if (ValueStack[ValueStack.Depth-1].stn is procedure_call && (ValueStack[ValueStack.Depth-1].stn as procedure_call).is_ident)
        	{
        		CurrentSemanticValue.stn = NewPropertySpecifiersWrite(ValueStack[ValueStack.Depth-2].id, (ValueStack[ValueStack.Depth-1].stn as procedure_call).func_name as ident, null, null, null, CurrentLocationSpan); // ������ �������� - � ���������������
        	}
        	else 
        	{
				var id = NewId("#SetGen", LocationStack[LocationStack.Depth-1]);
                procedure_definition pr = null;
                if (!parsertools.build_tree_for_formatter)
                    pr = CreateAndAddToClassWriteProc(ValueStack[ValueStack.Depth-1].stn as statement,id,LocationStack[LocationStack.Depth-1]);
                if (parsertools.build_tree_for_formatter)
					CurrentSemanticValue.stn = NewPropertySpecifiersWrite(ValueStack[ValueStack.Depth-2].id, id, pr, ValueStack[ValueStack.Depth-1].stn as statement, null, CurrentLocationSpan);
				else CurrentSemanticValue.stn = NewPropertySpecifiersWrite(ValueStack[ValueStack.Depth-2].id, id, pr, null, null, CurrentLocationSpan);	
			}
       }
        break;
      case 402: // read_property_specifiers -> tkRead, optional_read_expr
{ 
        	if (ValueStack[ValueStack.Depth-1].ex == null || ValueStack[ValueStack.Depth-1].ex is ident)
        	{
        		CurrentSemanticValue.stn = NewPropertySpecifiersRead(ValueStack[ValueStack.Depth-2].id, ValueStack[ValueStack.Depth-1].ex as ident, null, null, null, CurrentLocationSpan);
        	}
        	else 
        	{
				var id = NewId("#GetGen", LocationStack[LocationStack.Depth-1]);
                procedure_definition pr = null;
                if (!parsertools.build_tree_for_formatter)
                    pr = CreateAndAddToClassReadFunc(ValueStack[ValueStack.Depth-1].ex,id,LocationStack[LocationStack.Depth-1]);
				CurrentSemanticValue.stn = NewPropertySpecifiersRead(ValueStack[ValueStack.Depth-2].id, id, pr, ValueStack[ValueStack.Depth-1].ex, null, CurrentLocationSpan);
			}
       }
        break;
      case 403: // var_decl -> var_decl_part, tkSemiColon
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-2].stn; }
        break;
      case 406: // var_decl_part -> ident_list, tkColon, type_ref
{ 
			CurrentSemanticValue.stn = new var_def_statement(ValueStack[ValueStack.Depth-3].stn as ident_list, ValueStack[ValueStack.Depth-1].td, null, definition_attribute.None, false, CurrentLocationSpan);
		}
        break;
      case 407: // var_decl_part -> ident_list, tkAssign, expr_with_func_decl_lambda
{ 
			CurrentSemanticValue.stn = new var_def_statement(ValueStack[ValueStack.Depth-3].stn as ident_list, null, ValueStack[ValueStack.Depth-1].ex, definition_attribute.None, false, CurrentLocationSpan);		
		}
        break;
      case 408: // var_decl_part -> ident_list, tkColon, type_ref, tkAssignOrEqual, 
                //                  typed_var_init_expression
{ 
			CurrentSemanticValue.stn = new var_def_statement(ValueStack[ValueStack.Depth-5].stn as ident_list, ValueStack[ValueStack.Depth-3].td, ValueStack[ValueStack.Depth-1].ex, definition_attribute.None, false, CurrentLocationSpan); 
		}
        break;
      case 409: // typed_var_init_expression -> typed_const_plus
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 410: // typed_var_init_expression -> const_simple_expr, tkDotDot, const_term
{ 
		if (parsertools.build_tree_for_formatter)
			CurrentSemanticValue.ex = new diapason_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,CurrentLocationSpan);
		else 
			CurrentSemanticValue.ex = new diapason_expr_new(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,CurrentLocationSpan); 
		}
        break;
      case 411: // typed_var_init_expression -> expl_func_decl_lambda
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 412: // typed_var_init_expression -> identifier, tkArrow, lambda_function_body
{  
			var idList = new ident_list(ValueStack[ValueStack.Depth-3].id, LocationStack[LocationStack.Depth-3]); 
			var formalPars = new formal_parameters(new typed_parameters(idList, new lambda_inferred_type(new PascalABCCompiler.TreeRealization.lambda_any_type_node(), LocationStack[LocationStack.Depth-3]), parametr_kind.none, null, LocationStack[LocationStack.Depth-3]), LocationStack[LocationStack.Depth-3]);
			CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), formalPars, new lambda_inferred_type(new PascalABCCompiler.TreeRealization.lambda_any_type_node(), LocationStack[LocationStack.Depth-3]), ValueStack[ValueStack.Depth-1].stn as statement_list, CurrentLocationSpan);
		}
        break;
      case 413: // typed_var_init_expression -> tkRoundOpen, tkRoundClose, lambda_type_ref, 
                //                              tkArrow, lambda_function_body
{
			CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), null, ValueStack[ValueStack.Depth-3].td, ValueStack[ValueStack.Depth-1].stn as statement_list, CurrentLocationSpan);
		}
        break;
      case 414: // typed_var_init_expression -> tkRoundOpen, typed_const_list, tkRoundClose, 
                //                              tkArrow, lambda_function_body
{  
		    var el = ValueStack[ValueStack.Depth-4].stn as expression_list;
		    var cnt = el.Count;
		    
			var idList = new ident_list();
			idList.source_context = LocationStack[LocationStack.Depth-4];
			
			for (int j = 0; j < cnt; j++)
			{
				if (!(el.expressions[j] is ident))
					parsertools.AddErrorFromResource("ONE_TKIDENTIFIER",el.expressions[j].source_context);
				idList.idents.Add(el.expressions[j] as ident);
			}	
				
			var any = new lambda_inferred_type(new PascalABCCompiler.TreeRealization.lambda_any_type_node(), LocationStack[LocationStack.Depth-4]);	
				
			var formalPars = new formal_parameters(new typed_parameters(idList, any, parametr_kind.none, null, LocationStack[LocationStack.Depth-4]), LocationStack[LocationStack.Depth-4]);
			CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), formalPars, any, ValueStack[ValueStack.Depth-1].stn as statement_list, CurrentLocationSpan);
		}
        break;
      case 415: // typed_const_plus -> typed_const
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 416: // constr_destr_decl -> constr_destr_header, block
{ 
			CurrentSemanticValue.stn = new procedure_definition(ValueStack[ValueStack.Depth-2].td as procedure_header, ValueStack[ValueStack.Depth-1].stn as block, CurrentLocationSpan);
        }
        break;
      case 417: // constr_destr_decl -> tkConstructor, optional_proc_name, fp_list, tkAssign, 
                //                      unlabelled_stmt, tkSemiColon
{ 
   			if (ValueStack[ValueStack.Depth-2].stn is empty_statement)
				parsertools.AddErrorFromResource("EMPTY_STATEMENT_IN_SHORT_PROC_DEFINITION",LocationStack[LocationStack.Depth-1]);
            var tmp = new constructor(null,ValueStack[ValueStack.Depth-4].stn as formal_parameters,new procedure_attributes_list(new List<procedure_attribute>(),CurrentLocationSpan),ValueStack[ValueStack.Depth-5].stn as method_name,false,false,null,null,LexLocation.MergeAll(LocationStack[LocationStack.Depth-6],LocationStack[LocationStack.Depth-5],LocationStack[LocationStack.Depth-4]));
            CurrentSemanticValue.stn = new procedure_definition(tmp as procedure_header, new block(null,new statement_list(ValueStack[ValueStack.Depth-2].stn as statement,LocationStack[LocationStack.Depth-2]),LocationStack[LocationStack.Depth-2]), LocationStack[LocationStack.Depth-6].Merge(LocationStack[LocationStack.Depth-2]));
            if (parsertools.build_tree_for_formatter)
				CurrentSemanticValue.stn = new short_func_definition(CurrentSemanticValue.stn as procedure_definition);
        }
        break;
      case 418: // constr_destr_decl -> class_or_static, tkConstructor, optional_proc_name, 
                //                      fp_list, tkAssign, unlabelled_stmt, tkSemiColon
{ 
   			if (ValueStack[ValueStack.Depth-2].stn is empty_statement)
				parsertools.AddErrorFromResource("EMPTY_STATEMENT_IN_SHORT_PROC_DEFINITION",LocationStack[LocationStack.Depth-1]);
            var tmp = new constructor(null,ValueStack[ValueStack.Depth-4].stn as formal_parameters,new procedure_attributes_list(new List<procedure_attribute>(),CurrentLocationSpan),ValueStack[ValueStack.Depth-5].stn as method_name,false,true,null,null,LexLocation.MergeAll(LocationStack[LocationStack.Depth-7],LocationStack[LocationStack.Depth-6],LocationStack[LocationStack.Depth-5],LocationStack[LocationStack.Depth-4]));
            CurrentSemanticValue.stn = new procedure_definition(tmp as procedure_header, new block(null,new statement_list(ValueStack[ValueStack.Depth-2].stn as statement,LocationStack[LocationStack.Depth-2]),LocationStack[LocationStack.Depth-2]), LocationStack[LocationStack.Depth-7].Merge(LocationStack[LocationStack.Depth-2]));
            if (parsertools.build_tree_for_formatter)
				CurrentSemanticValue.stn = new short_func_definition(CurrentSemanticValue.stn as procedure_definition);
        }
        break;
      case 419: // inclass_constr_destr_decl -> constr_destr_header, inclass_block
{ 
			CurrentSemanticValue.stn = new procedure_definition(ValueStack[ValueStack.Depth-2].td as procedure_header, ValueStack[ValueStack.Depth-1].stn as block, CurrentLocationSpan);
        }
        break;
      case 420: // inclass_constr_destr_decl -> tkConstructor, optional_proc_name, fp_list, 
                //                              tkAssign, unlabelled_stmt, tkSemiColon
{ 
   			if (ValueStack[ValueStack.Depth-2].stn is empty_statement)
				parsertools.AddErrorFromResource("EMPTY_STATEMENT_IN_SHORT_PROC_DEFINITION",LocationStack[LocationStack.Depth-1]);
            var tmp = new constructor(null,ValueStack[ValueStack.Depth-4].stn as formal_parameters,new procedure_attributes_list(new List<procedure_attribute>(),CurrentLocationSpan),ValueStack[ValueStack.Depth-5].stn as method_name,false,false,null,null,LexLocation.MergeAll(LocationStack[LocationStack.Depth-6],LocationStack[LocationStack.Depth-5],LocationStack[LocationStack.Depth-4]));
            CurrentSemanticValue.stn = new procedure_definition(tmp as procedure_header, new block(null,new statement_list(ValueStack[ValueStack.Depth-2].stn as statement,LocationStack[LocationStack.Depth-2]),LocationStack[LocationStack.Depth-2]), LocationStack[LocationStack.Depth-6].Merge(LocationStack[LocationStack.Depth-2]));
            if (parsertools.build_tree_for_formatter)
				CurrentSemanticValue.stn = new short_func_definition(CurrentSemanticValue.stn as procedure_definition);
        }
        break;
      case 421: // inclass_constr_destr_decl -> class_or_static, tkConstructor, optional_proc_name, 
                //                              fp_list, tkAssign, unlabelled_stmt, tkSemiColon
{ 
   			if (ValueStack[ValueStack.Depth-2].stn is empty_statement)
				parsertools.AddErrorFromResource("EMPTY_STATEMENT_IN_SHORT_PROC_DEFINITION",LocationStack[LocationStack.Depth-1]);
            var tmp = new constructor(null,ValueStack[ValueStack.Depth-4].stn as formal_parameters,new procedure_attributes_list(new List<procedure_attribute>(),CurrentLocationSpan),ValueStack[ValueStack.Depth-5].stn as method_name,false,true,null,null,LexLocation.MergeAll(LocationStack[LocationStack.Depth-7],LocationStack[LocationStack.Depth-6],LocationStack[LocationStack.Depth-5],LocationStack[LocationStack.Depth-4]));
            CurrentSemanticValue.stn = new procedure_definition(tmp as procedure_header, new block(null,new statement_list(ValueStack[ValueStack.Depth-2].stn as statement,LocationStack[LocationStack.Depth-2]),LocationStack[LocationStack.Depth-2]), LocationStack[LocationStack.Depth-7].Merge(LocationStack[LocationStack.Depth-2]));
            if (parsertools.build_tree_for_formatter)
				CurrentSemanticValue.stn = new short_func_definition(CurrentSemanticValue.stn as procedure_definition);
        }
        break;
      case 422: // proc_func_decl -> proc_func_decl_noclass
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 423: // proc_func_decl -> class_or_static, proc_func_decl_noclass
{ 
			(ValueStack[ValueStack.Depth-1].stn as procedure_definition).proc_header.class_keyword = true;
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn;
		}
        break;
      case 424: // proc_func_decl_noclass -> proc_func_header, proc_func_external_block
{
            CurrentSemanticValue.stn = new procedure_definition(ValueStack[ValueStack.Depth-2].td as procedure_header, ValueStack[ValueStack.Depth-1].stn as proc_block, CurrentLocationSpan);
        }
        break;
      case 425: // proc_func_decl_noclass -> tkFunction, func_name, fp_list, tkColon, fptype, 
                //                           optional_method_modificators1, tkAssign, expr_l1, 
                //                           tkSemiColon
{
			CurrentSemanticValue.stn = SyntaxTreeBuilder.BuildShortFuncDefinition(ValueStack[ValueStack.Depth-7].stn as formal_parameters, ValueStack[ValueStack.Depth-4].stn as procedure_attributes_list, ValueStack[ValueStack.Depth-8].stn as method_name, ValueStack[ValueStack.Depth-5].td as type_definition, ValueStack[ValueStack.Depth-2].ex, LocationStack[LocationStack.Depth-9].Merge(LocationStack[LocationStack.Depth-4]));
		}
        break;
      case 426: // proc_func_decl_noclass -> tkFunction, func_name, fp_list, 
                //                           optional_method_modificators1, tkAssign, expr_l1, 
                //                           tkSemiColon
{
			if (ValueStack[ValueStack.Depth-2].ex is dot_question_node)
				parsertools.AddErrorFromResource("DOT_QUECTION_IN_SHORT_FUN",LocationStack[LocationStack.Depth-2]);
	
			CurrentSemanticValue.stn = SyntaxTreeBuilder.BuildShortFuncDefinition(ValueStack[ValueStack.Depth-5].stn as formal_parameters, ValueStack[ValueStack.Depth-4].stn as procedure_attributes_list, ValueStack[ValueStack.Depth-6].stn as method_name, null, ValueStack[ValueStack.Depth-2].ex, LocationStack[LocationStack.Depth-7].Merge(LocationStack[LocationStack.Depth-4]));
		}
        break;
      case 427: // proc_func_decl_noclass -> tkFunction, func_name, fp_list, tkColon, fptype, 
                //                           optional_method_modificators1, tkAssign, 
                //                           func_decl_lambda, tkSemiColon
{
			CurrentSemanticValue.stn = SyntaxTreeBuilder.BuildShortFuncDefinition(ValueStack[ValueStack.Depth-7].stn as formal_parameters, ValueStack[ValueStack.Depth-4].stn as procedure_attributes_list, ValueStack[ValueStack.Depth-8].stn as method_name, ValueStack[ValueStack.Depth-5].td as type_definition, ValueStack[ValueStack.Depth-2].ex, LocationStack[LocationStack.Depth-9].Merge(LocationStack[LocationStack.Depth-4]));
		}
        break;
      case 428: // proc_func_decl_noclass -> tkFunction, func_name, fp_list, 
                //                           optional_method_modificators1, tkAssign, 
                //                           func_decl_lambda, tkSemiColon
{
			CurrentSemanticValue.stn = SyntaxTreeBuilder.BuildShortFuncDefinition(ValueStack[ValueStack.Depth-5].stn as formal_parameters, ValueStack[ValueStack.Depth-4].stn as procedure_attributes_list, ValueStack[ValueStack.Depth-6].stn as method_name, null, ValueStack[ValueStack.Depth-2].ex, LocationStack[LocationStack.Depth-7].Merge(LocationStack[LocationStack.Depth-4]));
		}
        break;
      case 429: // proc_func_decl_noclass -> tkProcedure, proc_name, fp_list, 
                //                           optional_method_modificators1, tkAssign, 
                //                           unlabelled_stmt, tkSemiColon
{
			if (ValueStack[ValueStack.Depth-2].stn is empty_statement)
				parsertools.AddErrorFromResource("EMPTY_STATEMENT_IN_SHORT_PROC_DEFINITION",LocationStack[LocationStack.Depth-2]);
			CurrentSemanticValue.stn = SyntaxTreeBuilder.BuildShortProcDefinition(ValueStack[ValueStack.Depth-5].stn as formal_parameters, ValueStack[ValueStack.Depth-4].stn as procedure_attributes_list, ValueStack[ValueStack.Depth-6].stn as method_name, ValueStack[ValueStack.Depth-2].stn as statement, LocationStack[LocationStack.Depth-7].Merge(LocationStack[LocationStack.Depth-4]));
		}
        break;
      case 430: // proc_func_decl_noclass -> proc_func_header, tkForward, tkSemiColon
{
			CurrentSemanticValue.stn = new procedure_definition(ValueStack[ValueStack.Depth-3].td as procedure_header, null, CurrentLocationSpan);
            (CurrentSemanticValue.stn as procedure_definition).proc_header.proc_attributes.Add((procedure_attribute)ValueStack[ValueStack.Depth-2].id, ValueStack[ValueStack.Depth-2].id.source_context);
		}
        break;
      case 431: // proc_func_decl_noclass -> tkConst, const_decl
{ 
			CurrentSemanticValue.stn = new consts_definitions_list(ValueStack[ValueStack.Depth-1].stn as const_definition, CurrentLocationSpan);
		}
        break;
      case 432: // inclass_proc_func_decl -> inclass_proc_func_decl_noclass
{ 
            CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; 
        }
        break;
      case 433: // inclass_proc_func_decl -> class_or_static, inclass_proc_func_decl_noclass
{ 
		    if ((ValueStack[ValueStack.Depth-1].stn as procedure_definition).proc_header != null)
				(ValueStack[ValueStack.Depth-1].stn as procedure_definition).proc_header.class_keyword = true;
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn;
		}
        break;
      case 434: // inclass_proc_func_decl_noclass -> proc_func_header, inclass_block
{
            CurrentSemanticValue.stn = new procedure_definition(ValueStack[ValueStack.Depth-2].td as procedure_header, ValueStack[ValueStack.Depth-1].stn as proc_block, CurrentLocationSpan);
		}
        break;
      case 435: // inclass_proc_func_decl_noclass -> tkFunction, func_name, fp_list, tkColon, 
                //                                   fptype, optional_method_modificators1, 
                //                                   tkAssign, expr_l1_func_decl_lambda, 
                //                                   tkSemiColon
{
			CurrentSemanticValue.stn = SyntaxTreeBuilder.BuildShortFuncDefinition(ValueStack[ValueStack.Depth-7].stn as formal_parameters, ValueStack[ValueStack.Depth-4].stn as procedure_attributes_list, ValueStack[ValueStack.Depth-8].stn as method_name, ValueStack[ValueStack.Depth-5].td as type_definition, ValueStack[ValueStack.Depth-2].ex, LocationStack[LocationStack.Depth-9].Merge(LocationStack[LocationStack.Depth-4]));
			if (parsertools.build_tree_for_formatter)
				CurrentSemanticValue.stn = new short_func_definition(CurrentSemanticValue.stn as procedure_definition);
		}
        break;
      case 436: // inclass_proc_func_decl_noclass -> tkFunction, func_name, fp_list, 
                //                                   optional_method_modificators1, tkAssign, 
                //                                   expr_l1_func_decl_lambda, tkSemiColon
{
			CurrentSemanticValue.stn = SyntaxTreeBuilder.BuildShortFuncDefinition(ValueStack[ValueStack.Depth-5].stn as formal_parameters, ValueStack[ValueStack.Depth-4].stn as procedure_attributes_list, ValueStack[ValueStack.Depth-6].stn as method_name, null, ValueStack[ValueStack.Depth-2].ex, LocationStack[LocationStack.Depth-7].Merge(LocationStack[LocationStack.Depth-4]));
			if (parsertools.build_tree_for_formatter)
				CurrentSemanticValue.stn = new short_func_definition(CurrentSemanticValue.stn as procedure_definition);
		}
        break;
      case 437: // inclass_proc_func_decl_noclass -> tkProcedure, proc_name, fp_list, 
                //                                   optional_method_modificators1, tkAssign, 
                //                                   unlabelled_stmt, tkSemiColon
{
			CurrentSemanticValue.stn = SyntaxTreeBuilder.BuildShortProcDefinition(ValueStack[ValueStack.Depth-5].stn as formal_parameters, ValueStack[ValueStack.Depth-4].stn as procedure_attributes_list, ValueStack[ValueStack.Depth-6].stn as method_name, ValueStack[ValueStack.Depth-2].stn as statement, LocationStack[LocationStack.Depth-7].Merge(LocationStack[LocationStack.Depth-4]));
			if (parsertools.build_tree_for_formatter)
				CurrentSemanticValue.stn = new short_func_definition(CurrentSemanticValue.stn as procedure_definition);
		}
        break;
      case 438: // proc_func_external_block -> block
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 439: // proc_func_external_block -> external_block
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 440: // proc_name -> func_name
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 441: // func_name -> func_meth_name_ident
{ 
			CurrentSemanticValue.stn = new method_name(null,null, ValueStack[ValueStack.Depth-1].id, null, CurrentLocationSpan); 
		}
        break;
      case 442: // func_name -> func_class_name_ident_list, tkPoint, func_meth_name_ident
{ 
        	var ln = ValueStack[ValueStack.Depth-3].ob as List<ident>;
        	var cnt = ln.Count;
        	if (cnt == 1)
				CurrentSemanticValue.stn = new method_name(null, ln[cnt-1], ValueStack[ValueStack.Depth-1].id, null, CurrentLocationSpan);
			else 	
				CurrentSemanticValue.stn = new method_name(ln, ln[cnt-1], ValueStack[ValueStack.Depth-1].id, null, CurrentLocationSpan);
		}
        break;
      case 443: // func_class_name_ident -> func_name_with_template_args
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 444: // func_class_name_ident_list -> func_class_name_ident
{ 
			CurrentSemanticValue.ob = new List<ident>(); 
			(CurrentSemanticValue.ob as List<ident>).Add(ValueStack[ValueStack.Depth-1].id);
		}
        break;
      case 445: // func_class_name_ident_list -> func_class_name_ident_list, tkPoint, 
                //                               func_class_name_ident
{ 
			(ValueStack[ValueStack.Depth-3].ob as List<ident>).Add(ValueStack[ValueStack.Depth-1].id);
			CurrentSemanticValue.ob = ValueStack[ValueStack.Depth-3].ob; 
		}
        break;
      case 446: // func_meth_name_ident -> func_name_with_template_args
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 447: // func_meth_name_ident -> operator_name_ident
{ CurrentSemanticValue.id = (ident)ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 448: // func_meth_name_ident -> operator_name_ident, template_arguments
{ CurrentSemanticValue.id = new template_operator_name(null, ValueStack[ValueStack.Depth-1].stn as ident_list, ValueStack[ValueStack.Depth-2].ex as operator_name_ident, CurrentLocationSpan); }
        break;
      case 449: // func_name_with_template_args -> func_name_ident
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 450: // func_name_with_template_args -> func_name_ident, template_arguments
{ 
			CurrentSemanticValue.id = new template_type_name(ValueStack[ValueStack.Depth-2].id.name, ValueStack[ValueStack.Depth-1].stn as ident_list, CurrentLocationSpan); 
        }
        break;
      case 451: // func_name_ident -> identifier
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 452: // proc_header -> tkProcedure, proc_name, fp_list, optional_method_modificators, 
                //                optional_where_section
{ 
        	CurrentSemanticValue.td = new procedure_header(ValueStack[ValueStack.Depth-3].stn as formal_parameters, ValueStack[ValueStack.Depth-2].stn as procedure_attributes_list, ValueStack[ValueStack.Depth-4].stn as method_name, ValueStack[ValueStack.Depth-1].stn as where_definition_list, CurrentLocationSpan); 
        }
        break;
      case 453: // func_header -> tkFunction, func_name, fp_list, optional_method_modificators, 
                //                optional_where_section
{
			CurrentSemanticValue.td = new function_header(ValueStack[ValueStack.Depth-3].stn as formal_parameters, ValueStack[ValueStack.Depth-2].stn as procedure_attributes_list, ValueStack[ValueStack.Depth-4].stn as method_name, ValueStack[ValueStack.Depth-1].stn as where_definition_list, null, CurrentLocationSpan); 
		}
        break;
      case 454: // func_header -> tkFunction, func_name, fp_list, tkColon, fptype, 
                //                optional_method_modificators, optional_where_section
{ 
			CurrentSemanticValue.td = new function_header(ValueStack[ValueStack.Depth-5].stn as formal_parameters, ValueStack[ValueStack.Depth-2].stn as procedure_attributes_list, ValueStack[ValueStack.Depth-6].stn as method_name, ValueStack[ValueStack.Depth-1].stn as where_definition_list, ValueStack[ValueStack.Depth-3].td as type_definition, CurrentLocationSpan); 
        }
        break;
      case 455: // external_block -> tkExternal, external_directive_ident, tkName, 
                //                   external_directive_ident, tkSemiColon
{ 
			CurrentSemanticValue.stn = new external_directive(ValueStack[ValueStack.Depth-4].ex, ValueStack[ValueStack.Depth-2].ex, CurrentLocationSpan); 
		}
        break;
      case 456: // external_block -> tkExternal, external_directive_ident, tkSemiColon
{ 
			CurrentSemanticValue.stn = new external_directive(ValueStack[ValueStack.Depth-2].ex, null, CurrentLocationSpan); 
		}
        break;
      case 457: // external_block -> tkExternal, tkSemiColon
{ 
			CurrentSemanticValue.stn = new external_directive(null, null, CurrentLocationSpan); 
		}
        break;
      case 458: // external_directive_ident -> identifier
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 459: // external_directive_ident -> literal
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 460: // block -> decl_sect_list, compound_stmt, tkSemiColon
{ 
			CurrentSemanticValue.stn = new block(ValueStack[ValueStack.Depth-3].stn as declarations, ValueStack[ValueStack.Depth-2].stn as statement_list, CurrentLocationSpan); 
		}
        break;
      case 461: // inclass_block -> inclass_decl_sect_list, compound_stmt, tkSemiColon
{ 
			CurrentSemanticValue.stn = new block(ValueStack[ValueStack.Depth-3].stn as declarations, ValueStack[ValueStack.Depth-2].stn as statement_list, CurrentLocationSpan); 
		}
        break;
      case 462: // inclass_block -> external_block
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 463: // fp_list -> /* empty */
{ CurrentSemanticValue.stn = null; }
        break;
      case 464: // fp_list -> tkRoundOpen, tkRoundClose
{ 
			CurrentSemanticValue.stn = null;
		}
        break;
      case 465: // fp_list -> tkRoundOpen, fp_sect_list, tkRoundClose
{ 
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-2].stn;
			if (CurrentSemanticValue.stn != null)
				CurrentSemanticValue.stn.source_context = CurrentLocationSpan;
		}
        break;
      case 466: // fp_sect_list -> fp_sect
{ 
			CurrentSemanticValue.stn = new formal_parameters(ValueStack[ValueStack.Depth-1].stn as typed_parameters, CurrentLocationSpan);
        }
        break;
      case 467: // fp_sect_list -> fp_sect_list, tkSemiColon, fp_sect
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as formal_parameters).Add(ValueStack[ValueStack.Depth-1].stn as typed_parameters, CurrentLocationSpan);   
        }
        break;
      case 468: // fp_sect -> attribute_declarations, simple_fp_sect
{  
			(ValueStack[ValueStack.Depth-1].stn as declaration).attributes = ValueStack[ValueStack.Depth-2].stn as  attribute_list;
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn;
        }
        break;
      case 469: // simple_fp_sect -> param_name_list, tkColon, fptype
{ 
			CurrentSemanticValue.stn = new typed_parameters(ValueStack[ValueStack.Depth-3].stn as ident_list, ValueStack[ValueStack.Depth-1].td, parametr_kind.none, null, CurrentLocationSpan); 
		}
        break;
      case 470: // simple_fp_sect -> tkVar, param_name_list, tkColon, fptype
{ 
			CurrentSemanticValue.stn = new typed_parameters(ValueStack[ValueStack.Depth-3].stn as ident_list, ValueStack[ValueStack.Depth-1].td, parametr_kind.var_parametr, null, CurrentLocationSpan);  
		}
        break;
      case 471: // simple_fp_sect -> tkConst, param_name_list, tkColon, fptype
{ 
			CurrentSemanticValue.stn = new typed_parameters(ValueStack[ValueStack.Depth-3].stn as ident_list, ValueStack[ValueStack.Depth-1].td, parametr_kind.const_parametr, null, CurrentLocationSpan);  
		}
        break;
      case 472: // simple_fp_sect -> tkParams, param_name_list, tkColon, fptype
{ 
			CurrentSemanticValue.stn = new typed_parameters(ValueStack[ValueStack.Depth-3].stn as ident_list, ValueStack[ValueStack.Depth-1].td,parametr_kind.params_parametr,null, CurrentLocationSpan);  
		}
        break;
      case 473: // simple_fp_sect -> param_name_list, tkColon, fptype, tkAssign, expr
{ 
			CurrentSemanticValue.stn = new typed_parameters(ValueStack[ValueStack.Depth-5].stn as ident_list, ValueStack[ValueStack.Depth-3].td, parametr_kind.none, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan); 
		}
        break;
      case 474: // simple_fp_sect -> tkVar, param_name_list, tkColon, fptype, tkAssign, expr
{ 
			CurrentSemanticValue.stn = new typed_parameters(ValueStack[ValueStack.Depth-5].stn as ident_list, ValueStack[ValueStack.Depth-3].td, parametr_kind.var_parametr, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);  
		}
        break;
      case 475: // simple_fp_sect -> tkConst, param_name_list, tkColon, fptype, tkAssign, expr
{ 
			CurrentSemanticValue.stn = new typed_parameters(ValueStack[ValueStack.Depth-5].stn as ident_list, ValueStack[ValueStack.Depth-3].td, parametr_kind.const_parametr, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);  
		}
        break;
      case 476: // param_name_list -> param_name
{ 
			CurrentSemanticValue.stn = new ident_list(ValueStack[ValueStack.Depth-1].id, CurrentLocationSpan); 
		}
        break;
      case 477: // param_name_list -> param_name_list, tkComma, param_name
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as ident_list).Add(ValueStack[ValueStack.Depth-1].id, CurrentLocationSpan);  
		}
        break;
      case 478: // param_name -> identifier
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 479: // fptype -> type_ref
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 480: // fptype_noproctype -> simple_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 481: // fptype_noproctype -> string_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 482: // fptype_noproctype -> pointer_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 483: // fptype_noproctype -> structured_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 484: // fptype_noproctype -> template_type
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 485: // stmt -> unlabelled_stmt
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 486: // stmt -> label_name, tkColon, stmt
{ 
			CurrentSemanticValue.stn = new labeled_statement(ValueStack[ValueStack.Depth-3].id, ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan);  
		}
        break;
      case 487: // unlabelled_stmt -> /* empty */
{ 
			CurrentSemanticValue.stn = new empty_statement(); 
			CurrentSemanticValue.stn.source_context = null;
		}
        break;
      case 488: // unlabelled_stmt -> assignment
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 489: // unlabelled_stmt -> proc_call
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 490: // unlabelled_stmt -> goto_stmt
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 491: // unlabelled_stmt -> compound_stmt
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 492: // unlabelled_stmt -> if_stmt
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 493: // unlabelled_stmt -> case_stmt
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 494: // unlabelled_stmt -> repeat_stmt
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 495: // unlabelled_stmt -> while_stmt
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 496: // unlabelled_stmt -> for_stmt
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 497: // unlabelled_stmt -> with_stmt
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 498: // unlabelled_stmt -> inherited_message
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 499: // unlabelled_stmt -> try_stmt
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 500: // unlabelled_stmt -> raise_stmt
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 501: // unlabelled_stmt -> foreach_stmt
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 502: // unlabelled_stmt -> var_stmt
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 503: // unlabelled_stmt -> expr_as_stmt
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 504: // unlabelled_stmt -> lock_stmt
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 505: // unlabelled_stmt -> yield_stmt
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 506: // unlabelled_stmt -> yield_sequence_stmt
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 507: // unlabelled_stmt -> loop_stmt
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 508: // unlabelled_stmt -> match_with
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 509: // loop_stmt -> tkLoop, expr_l1, tkDo, unlabelled_stmt
{
			CurrentSemanticValue.stn = new loop_stmt(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].stn as statement,CurrentLocationSpan);
		}
        break;
      case 510: // yield_stmt -> tkYield, expr_l1_func_decl_lambda
{
			CurrentSemanticValue.stn = new yield_node(ValueStack[ValueStack.Depth-1].ex,CurrentLocationSpan);
		}
        break;
      case 511: // yield_sequence_stmt -> tkYield, tkSequence, expr_l1_func_decl_lambda
{
			CurrentSemanticValue.stn = new yield_sequence_node(ValueStack[ValueStack.Depth-1].ex,CurrentLocationSpan);
		}
        break;
      case 512: // var_stmt -> tkVar, var_decl_part
{ 
			CurrentSemanticValue.stn = new var_statement(ValueStack[ValueStack.Depth-1].stn as var_def_statement, CurrentLocationSpan);
		}
        break;
      case 513: // var_stmt -> tkRoundOpen, tkVar, identifier, tkComma, var_ident_list, 
                //             tkRoundClose, tkAssign, expr
{
			(ValueStack[ValueStack.Depth-4].ob as ident_list).Insert(0,ValueStack[ValueStack.Depth-6].id);
			(ValueStack[ValueStack.Depth-4].ob as syntax_tree_node).source_context = LexLocation.MergeAll(LocationStack[LocationStack.Depth-8],LocationStack[LocationStack.Depth-7],LocationStack[LocationStack.Depth-6],LocationStack[LocationStack.Depth-5],LocationStack[LocationStack.Depth-4],LocationStack[LocationStack.Depth-3]);
			CurrentSemanticValue.stn = new assign_var_tuple(ValueStack[ValueStack.Depth-4].ob as ident_list, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);
		}
        break;
      case 514: // var_stmt -> tkVar, tkRoundOpen, identifier, tkComma, ident_list, tkRoundClose, 
                //             tkAssign, expr
{
			(ValueStack[ValueStack.Depth-4].stn as ident_list).Insert(0,ValueStack[ValueStack.Depth-6].id);
			ValueStack[ValueStack.Depth-4].stn.source_context = LexLocation.MergeAll(LocationStack[LocationStack.Depth-8],LocationStack[LocationStack.Depth-7],LocationStack[LocationStack.Depth-6],LocationStack[LocationStack.Depth-5],LocationStack[LocationStack.Depth-4],LocationStack[LocationStack.Depth-3]);
			CurrentSemanticValue.stn = new assign_var_tuple(ValueStack[ValueStack.Depth-4].stn as ident_list, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);
	    }
        break;
      case 515: // assignment -> var_reference, assign_operator, expr_with_func_decl_lambda
{      
			CurrentSemanticValue.stn = new assign(ValueStack[ValueStack.Depth-3].ex as addressed_value, ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan);
        }
        break;
      case 516: // assignment -> tkRoundOpen, variable, tkComma, variable_list, tkRoundClose, 
                //               assign_operator, expr
{
			if (ValueStack[ValueStack.Depth-2].op.type != Operators.Assignment)
			    parsertools.AddErrorFromResource("ONLY_BASE_ASSIGNMENT_FOR_TUPLE",LocationStack[LocationStack.Depth-2]);
			(ValueStack[ValueStack.Depth-4].ob as addressed_value_list).Insert(0,ValueStack[ValueStack.Depth-6].ex as addressed_value);
			(ValueStack[ValueStack.Depth-4].ob as syntax_tree_node).source_context = LexLocation.MergeAll(LocationStack[LocationStack.Depth-7],LocationStack[LocationStack.Depth-6],LocationStack[LocationStack.Depth-5],LocationStack[LocationStack.Depth-4],LocationStack[LocationStack.Depth-3]);
			CurrentSemanticValue.stn = new assign_tuple(ValueStack[ValueStack.Depth-4].ob as addressed_value_list, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);
		}
        break;
      case 517: // assignment -> variable, tkQuestionSquareOpen, format_expr, tkSquareClose, 
                //               assign_operator, expr
{
			var fe = ValueStack[ValueStack.Depth-4].ex as format_expr;
            if (!parsertools.build_tree_for_formatter)
            {
                if (fe.expr == null)
                    fe.expr = new int32_const(int.MaxValue,LocationStack[LocationStack.Depth-4]);
                if (fe.format1 == null)
                    fe.format1 = new int32_const(int.MaxValue,LocationStack[LocationStack.Depth-4]);
            }
      		var left = new slice_expr_question(ValueStack[ValueStack.Depth-6].ex as addressed_value,fe.expr,fe.format1,fe.format2,CurrentLocationSpan);
            CurrentSemanticValue.stn = new assign(left, ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan);
		}
        break;
      case 518: // variable_list -> variable
{
		CurrentSemanticValue.ob = new addressed_value_list(ValueStack[ValueStack.Depth-1].ex as addressed_value,LocationStack[LocationStack.Depth-1]);
	}
        break;
      case 519: // variable_list -> variable_list, tkComma, variable
{
		(ValueStack[ValueStack.Depth-3].ob as addressed_value_list).Add(ValueStack[ValueStack.Depth-1].ex as addressed_value);
		(ValueStack[ValueStack.Depth-3].ob as syntax_tree_node).source_context = LexLocation.MergeAll(LocationStack[LocationStack.Depth-3],LocationStack[LocationStack.Depth-2],LocationStack[LocationStack.Depth-1]);
		CurrentSemanticValue.ob = ValueStack[ValueStack.Depth-3].ob;
	}
        break;
      case 520: // var_ident_list -> tkVar, identifier
{
		CurrentSemanticValue.ob = new ident_list(ValueStack[ValueStack.Depth-1].id,CurrentLocationSpan);
	}
        break;
      case 521: // var_ident_list -> var_ident_list, tkComma, tkVar, identifier
{
		(ValueStack[ValueStack.Depth-4].ob as ident_list).Add(ValueStack[ValueStack.Depth-1].id);
		(ValueStack[ValueStack.Depth-4].ob as ident_list).source_context = LexLocation.MergeAll(LocationStack[LocationStack.Depth-4],LocationStack[LocationStack.Depth-3],LocationStack[LocationStack.Depth-2],LocationStack[LocationStack.Depth-1]);
		CurrentSemanticValue.ob = ValueStack[ValueStack.Depth-4].ob;
	}
        break;
      case 522: // proc_call -> var_reference
{ 
			CurrentSemanticValue.stn = new procedure_call(ValueStack[ValueStack.Depth-1].ex as addressed_value, ValueStack[ValueStack.Depth-1].ex is ident, CurrentLocationSpan); 
		}
        break;
      case 523: // goto_stmt -> tkGoto, label_name
{ 
			CurrentSemanticValue.stn = new goto_statement(ValueStack[ValueStack.Depth-1].id, CurrentLocationSpan); 
		}
        break;
      case 524: // compound_stmt -> tkBegin, stmt_list, tkEnd
{
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-2].stn;
			(CurrentSemanticValue.stn as statement_list).left_logical_bracket = ValueStack[ValueStack.Depth-3].ti;
			(CurrentSemanticValue.stn as statement_list).right_logical_bracket = ValueStack[ValueStack.Depth-1].ti;
			CurrentSemanticValue.stn.source_context = CurrentLocationSpan;
        }
        break;
      case 525: // stmt_list -> stmt
{ 
			CurrentSemanticValue.stn = new statement_list(ValueStack[ValueStack.Depth-1].stn as statement, LocationStack[LocationStack.Depth-1]);
        }
        break;
      case 526: // stmt_list -> stmt_list, tkSemiColon, stmt
{  
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as statement_list).Add(ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan);
        }
        break;
      case 527: // if_stmt -> tkIf, expr_l1, tkThen, unlabelled_stmt
{ 
			CurrentSemanticValue.stn = new if_node(ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].stn as statement, null, CurrentLocationSpan); 
        }
        break;
      case 528: // if_stmt -> tkIf, expr_l1, tkThen, unlabelled_stmt, tkElse, unlabelled_stmt
{
			CurrentSemanticValue.stn = new if_node(ValueStack[ValueStack.Depth-5].ex, ValueStack[ValueStack.Depth-3].stn as statement, ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan); 
        }
        break;
      case 529: // match_with -> tkMatch, expr_l1, tkWith, pattern_cases, else_case, tkEnd
{ 
            CurrentSemanticValue.stn = new match_with(ValueStack[ValueStack.Depth-5].ex, ValueStack[ValueStack.Depth-3].stn as pattern_cases, ValueStack[ValueStack.Depth-2].stn as statement, CurrentLocationSpan);
        }
        break;
      case 530: // match_with -> tkMatch, expr_l1, tkWith, pattern_cases, tkSemiColon, else_case, 
                //               tkEnd
{ 
            CurrentSemanticValue.stn = new match_with(ValueStack[ValueStack.Depth-6].ex, ValueStack[ValueStack.Depth-4].stn as pattern_cases, ValueStack[ValueStack.Depth-2].stn as statement, CurrentLocationSpan);
        }
        break;
      case 531: // pattern_cases -> pattern_case
{
            CurrentSemanticValue.stn = new pattern_cases(ValueStack[ValueStack.Depth-1].stn as pattern_case);
        }
        break;
      case 532: // pattern_cases -> pattern_cases, tkSemiColon, pattern_case
{
            CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as pattern_cases).Add(ValueStack[ValueStack.Depth-1].stn as pattern_case);
        }
        break;
      case 533: // pattern_case -> pattern_optional_var, tkWhen, expr_l1, tkColon, unlabelled_stmt
{
            CurrentSemanticValue.stn = new pattern_case(ValueStack[ValueStack.Depth-5].stn as pattern_node, ValueStack[ValueStack.Depth-1].stn as statement, ValueStack[ValueStack.Depth-3].ex, CurrentLocationSpan);
        }
        break;
      case 534: // pattern_case -> deconstruction_or_const_pattern, tkColon, unlabelled_stmt
{
            CurrentSemanticValue.stn = new pattern_case(ValueStack[ValueStack.Depth-3].stn as pattern_node, ValueStack[ValueStack.Depth-1].stn as statement, null, CurrentLocationSpan);
        }
        break;
      case 535: // pattern_case -> collection_pattern, tkColon, unlabelled_stmt
{
			CurrentSemanticValue.stn = new pattern_case(ValueStack[ValueStack.Depth-3].stn as pattern_node, ValueStack[ValueStack.Depth-1].stn as statement, null, CurrentLocationSpan);
		}
        break;
      case 536: // pattern_case -> tuple_pattern, tkWhen, expr_l1, tkColon, unlabelled_stmt
{
			CurrentSemanticValue.stn = new pattern_case(ValueStack[ValueStack.Depth-5].stn as pattern_node, ValueStack[ValueStack.Depth-1].stn as statement, ValueStack[ValueStack.Depth-3].ex, CurrentLocationSpan);
		}
        break;
      case 537: // pattern_case -> tuple_pattern, tkColon, unlabelled_stmt
{
			CurrentSemanticValue.stn = new pattern_case(ValueStack[ValueStack.Depth-3].stn as pattern_node, ValueStack[ValueStack.Depth-1].stn as statement, null, CurrentLocationSpan);
		}
        break;
      case 538: // case_stmt -> tkCase, expr_l1, tkOf, case_list, else_case, tkEnd
{ 
			CurrentSemanticValue.stn = new case_node(ValueStack[ValueStack.Depth-5].ex, ValueStack[ValueStack.Depth-3].stn as case_variants, ValueStack[ValueStack.Depth-2].stn as statement, CurrentLocationSpan); 
		}
        break;
      case 539: // case_stmt -> tkCase, expr_l1, tkOf, case_list, tkSemiColon, else_case, tkEnd
{ 
			CurrentSemanticValue.stn = new case_node(ValueStack[ValueStack.Depth-6].ex, ValueStack[ValueStack.Depth-4].stn as case_variants, ValueStack[ValueStack.Depth-2].stn as statement, CurrentLocationSpan); 
		}
        break;
      case 540: // case_stmt -> tkCase, expr_l1, tkOf, else_case, tkEnd
{ 
			CurrentSemanticValue.stn = new case_node(ValueStack[ValueStack.Depth-4].ex, NewCaseItem(new empty_statement(), null), ValueStack[ValueStack.Depth-2].stn as statement, CurrentLocationSpan); 
		}
        break;
      case 541: // case_list -> case_item
{
			if (ValueStack[ValueStack.Depth-1].stn is empty_statement) 
				CurrentSemanticValue.stn = NewCaseItem(ValueStack[ValueStack.Depth-1].stn, null);
			else CurrentSemanticValue.stn = NewCaseItem(ValueStack[ValueStack.Depth-1].stn, CurrentLocationSpan);
		}
        break;
      case 542: // case_list -> case_list, tkSemiColon, case_item
{ 
			CurrentSemanticValue.stn = AddCaseItem(ValueStack[ValueStack.Depth-3].stn as case_variants, ValueStack[ValueStack.Depth-1].stn, CurrentLocationSpan);
		}
        break;
      case 543: // case_item -> case_label_list, tkColon, unlabelled_stmt
{ 
			CurrentSemanticValue.stn = new case_variant(ValueStack[ValueStack.Depth-3].stn as expression_list, ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan); 
		}
        break;
      case 544: // case_label_list -> case_label
{ 
			CurrentSemanticValue.stn = new expression_list(ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);
		}
        break;
      case 545: // case_label_list -> case_label_list, tkComma, case_label
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as expression_list).Add(ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);
		}
        break;
      case 546: // case_label -> const_elem
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 547: // else_case -> /* empty */
{ CurrentSemanticValue.stn = null;}
        break;
      case 548: // else_case -> tkElse, stmt_list
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 549: // repeat_stmt -> tkRepeat, stmt_list, tkUntil, expr
{ 
		    CurrentSemanticValue.stn = new repeat_node(ValueStack[ValueStack.Depth-3].stn as statement_list, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan); 
			(ValueStack[ValueStack.Depth-3].stn as statement_list).left_logical_bracket = ValueStack[ValueStack.Depth-4].ti;
			(ValueStack[ValueStack.Depth-3].stn as statement_list).right_logical_bracket = ValueStack[ValueStack.Depth-2].ti;
			ValueStack[ValueStack.Depth-3].stn.source_context = LocationStack[LocationStack.Depth-4].Merge(LocationStack[LocationStack.Depth-2]);
        }
        break;
      case 550: // while_stmt -> tkWhile, expr_l1, optional_tk_do, unlabelled_stmt
{ 
			CurrentSemanticValue.stn = NewWhileStmt(ValueStack[ValueStack.Depth-4].ti, ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-2].ti, ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan);    
        }
        break;
      case 551: // optional_tk_do -> tkDo
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 552: // optional_tk_do -> /* empty */
{ CurrentSemanticValue.ti = null; }
        break;
      case 553: // lock_stmt -> tkLock, expr_l1, tkDo, unlabelled_stmt
{ 
			CurrentSemanticValue.stn = new lock_stmt(ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan); 
        }
        break;
      case 554: // foreach_stmt -> tkForeach, identifier, foreach_stmt_ident_dype_opt, tkIn, 
                //                 expr_l1, tkDo, unlabelled_stmt
{ 
			CurrentSemanticValue.stn = new foreach_stmt(ValueStack[ValueStack.Depth-6].id, ValueStack[ValueStack.Depth-5].td, ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan);
            if (ValueStack[ValueStack.Depth-5].td == null)
                parsertools.AddWarningFromResource("USING_UNLOCAL_FOREACH_VARIABLE", ValueStack[ValueStack.Depth-6].id.source_context);
        }
        break;
      case 555: // foreach_stmt -> tkForeach, tkVar, identifier, tkColon, type_ref, tkIn, expr_l1, 
                //                 tkDo, unlabelled_stmt
{ 
			CurrentSemanticValue.stn = new foreach_stmt(ValueStack[ValueStack.Depth-7].id, ValueStack[ValueStack.Depth-5].td, ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan); 
        }
        break;
      case 556: // foreach_stmt -> tkForeach, tkVar, identifier, tkIn, expr_l1, tkDo, 
                //                 unlabelled_stmt
{ 
			CurrentSemanticValue.stn = new foreach_stmt(ValueStack[ValueStack.Depth-5].id, new no_type_foreach(), ValueStack[ValueStack.Depth-3].ex, (statement)ValueStack[ValueStack.Depth-1].stn, CurrentLocationSpan); 
        }
        break;
      case 557: // foreach_stmt -> tkForeach, tkVar, tkRoundOpen, ident_list, tkRoundClose, tkIn, 
                //                 expr_l1, tkDo, unlabelled_stmt
{ 
        	if (parsertools.build_tree_for_formatter)
        	{
        		var il = ValueStack[ValueStack.Depth-6].stn as ident_list;
        		il.source_context = LexLocation.MergeAll(LocationStack[LocationStack.Depth-6],LocationStack[LocationStack.Depth-5]); // ����� ��� ��������������
        		CurrentSemanticValue.stn = new foreach_stmt_formatting(il,ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].stn as statement,CurrentLocationSpan);
        	}
        	else
        	{
        		// ���� �������� - ���������, ��� ����� ������� ������������ ���� ��� ��������
        		// ��������� ����� � � foreach, �� ���-�� ������ ���� ������, ��� ��� �������� ����
        		// ��������, ������������� #fe - �� ��� ������ ����
                var id = NewId("#fe",LocationStack[LocationStack.Depth-6]);
                var tttt = new assign_var_tuple(ValueStack[ValueStack.Depth-6].stn as ident_list, id, CurrentLocationSpan);
                statement_list nine = ValueStack[ValueStack.Depth-1].stn is statement_list ? ValueStack[ValueStack.Depth-1].stn as statement_list : new statement_list(ValueStack[ValueStack.Depth-1].stn as statement,LocationStack[LocationStack.Depth-1]);
                nine.Insert(0,tttt);
			    var fe = new foreach_stmt(id, new no_type_foreach(), ValueStack[ValueStack.Depth-3].ex, nine, CurrentLocationSpan);
			    fe.ext = ValueStack[ValueStack.Depth-6].stn as ident_list;
			    CurrentSemanticValue.stn = fe;
			}
        }
        break;
      case 558: // foreach_stmt_ident_dype_opt -> tkColon, type_ref
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 560: // for_stmt -> tkFor, optional_var, identifier, for_stmt_decl_or_assign, expr_l1, 
                //             for_cycle_type, expr_l1, optional_tk_do, unlabelled_stmt
{ 
			CurrentSemanticValue.stn = NewForStmt((bool)ValueStack[ValueStack.Depth-8].ob, ValueStack[ValueStack.Depth-7].id, ValueStack[ValueStack.Depth-6].td, ValueStack[ValueStack.Depth-5].ex, (for_cycle_type)ValueStack[ValueStack.Depth-4].ob, ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-2].ti, ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan);
        }
        break;
      case 561: // optional_var -> tkVar
{ CurrentSemanticValue.ob = true; }
        break;
      case 562: // optional_var -> /* empty */
{ CurrentSemanticValue.ob = false; }
        break;
      case 564: // for_stmt_decl_or_assign -> tkColon, simple_type_identifier, tkAssign
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-2].td; }
        break;
      case 565: // for_cycle_type -> tkTo
{ CurrentSemanticValue.ob = for_cycle_type.to; }
        break;
      case 566: // for_cycle_type -> tkDownto
{ CurrentSemanticValue.ob = for_cycle_type.downto; }
        break;
      case 567: // with_stmt -> tkWith, expr_list, tkDo, unlabelled_stmt
{ 
			CurrentSemanticValue.stn = new with_statement(ValueStack[ValueStack.Depth-1].stn as statement, ValueStack[ValueStack.Depth-3].stn as expression_list, CurrentLocationSpan); 
		}
        break;
      case 568: // inherited_message -> tkInherited
{ 
			CurrentSemanticValue.stn = new inherited_message();  
			CurrentSemanticValue.stn.source_context = CurrentLocationSpan;
		}
        break;
      case 569: // try_stmt -> tkTry, stmt_list, try_handler
{ 
			CurrentSemanticValue.stn = new try_stmt(ValueStack[ValueStack.Depth-2].stn as statement_list, ValueStack[ValueStack.Depth-1].stn as try_handler, CurrentLocationSpan); 
			(ValueStack[ValueStack.Depth-2].stn as statement_list).left_logical_bracket = ValueStack[ValueStack.Depth-3].ti;
			ValueStack[ValueStack.Depth-2].stn.source_context = LocationStack[LocationStack.Depth-3].Merge(LocationStack[LocationStack.Depth-2]);
        }
        break;
      case 570: // try_handler -> tkFinally, stmt_list, tkEnd
{ 
			CurrentSemanticValue.stn = new try_handler_finally(ValueStack[ValueStack.Depth-2].stn as statement_list, CurrentLocationSpan);
			(ValueStack[ValueStack.Depth-2].stn as statement_list).left_logical_bracket = ValueStack[ValueStack.Depth-3].ti;
			(ValueStack[ValueStack.Depth-2].stn as statement_list).right_logical_bracket = ValueStack[ValueStack.Depth-1].ti;
		}
        break;
      case 571: // try_handler -> tkExcept, exception_block, tkEnd
{ 
			CurrentSemanticValue.stn = new try_handler_except((exception_block)ValueStack[ValueStack.Depth-2].stn, CurrentLocationSpan);  
			if ((ValueStack[ValueStack.Depth-2].stn as exception_block).stmt_list != null)
			{
				(ValueStack[ValueStack.Depth-2].stn as exception_block).stmt_list.source_context = CurrentLocationSpan;
				(ValueStack[ValueStack.Depth-2].stn as exception_block).source_context = CurrentLocationSpan;
			}
		}
        break;
      case 572: // exception_block -> exception_handler_list, exception_block_else_branch
{ 
			CurrentSemanticValue.stn = new exception_block(null, (exception_handler_list)ValueStack[ValueStack.Depth-2].stn, (statement_list)ValueStack[ValueStack.Depth-1].stn, CurrentLocationSpan); 
		}
        break;
      case 573: // exception_block -> exception_handler_list, tkSemiColon, 
                //                    exception_block_else_branch
{ 
			CurrentSemanticValue.stn = new exception_block(null, (exception_handler_list)ValueStack[ValueStack.Depth-3].stn, (statement_list)ValueStack[ValueStack.Depth-1].stn, CurrentLocationSpan); 
		}
        break;
      case 574: // exception_block -> stmt_list
{ 
			CurrentSemanticValue.stn = new exception_block(ValueStack[ValueStack.Depth-1].stn as statement_list, null, null, LocationStack[LocationStack.Depth-1]);
		}
        break;
      case 575: // exception_handler_list -> exception_handler
{ 
			CurrentSemanticValue.stn = new exception_handler_list(ValueStack[ValueStack.Depth-1].stn as exception_handler, CurrentLocationSpan); 
		}
        break;
      case 576: // exception_handler_list -> exception_handler_list, tkSemiColon, 
                //                           exception_handler
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as exception_handler_list).Add(ValueStack[ValueStack.Depth-1].stn as exception_handler, CurrentLocationSpan); 
		}
        break;
      case 577: // exception_block_else_branch -> /* empty */
{ CurrentSemanticValue.stn = null; }
        break;
      case 578: // exception_block_else_branch -> tkElse, stmt_list
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 579: // exception_handler -> tkOn, exception_identifier, tkDo, unlabelled_stmt
{ 
			CurrentSemanticValue.stn = new exception_handler((ValueStack[ValueStack.Depth-3].stn as exception_ident).variable, (ValueStack[ValueStack.Depth-3].stn as exception_ident).type_name, ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan);
		}
        break;
      case 580: // exception_identifier -> exception_class_type_identifier
{ 
			CurrentSemanticValue.stn = new exception_ident(null, (named_type_reference)ValueStack[ValueStack.Depth-1].td, CurrentLocationSpan); 
		}
        break;
      case 581: // exception_identifier -> exception_variable, tkColon, 
                //                         exception_class_type_identifier
{ 
			CurrentSemanticValue.stn = new exception_ident(ValueStack[ValueStack.Depth-3].id, (named_type_reference)ValueStack[ValueStack.Depth-1].td, CurrentLocationSpan); 
		}
        break;
      case 582: // exception_class_type_identifier -> simple_type_identifier
{ CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 583: // exception_variable -> identifier
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 584: // raise_stmt -> tkRaise
{ 
			CurrentSemanticValue.stn = new raise_stmt(); 
			CurrentSemanticValue.stn.source_context = CurrentLocationSpan;
		}
        break;
      case 585: // raise_stmt -> tkRaise, expr
{ 
			CurrentSemanticValue.stn = new raise_stmt(ValueStack[ValueStack.Depth-1].ex, null, CurrentLocationSpan);  
		}
        break;
      case 586: // expr_list -> expr_with_func_decl_lambda
{ 
			CurrentSemanticValue.stn = new expression_list(ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan); 
		}
        break;
      case 587: // expr_list -> expr_list, tkComma, expr_with_func_decl_lambda
{
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as expression_list).Add(ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan); 
		}
        break;
      case 588: // expr_as_stmt -> allowable_expr_as_stmt
{ 
			CurrentSemanticValue.stn = new expression_as_statement(ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);  
		}
        break;
      case 589: // allowable_expr_as_stmt -> new_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 590: // expr_with_func_decl_lambda -> expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 591: // expr_with_func_decl_lambda -> func_decl_lambda
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 592: // expr_with_func_decl_lambda -> tkInherited
{ CurrentSemanticValue.ex = new inherited_ident("", CurrentLocationSpan); }
        break;
      case 593: // expr -> expr_l1
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 594: // expr -> format_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 595: // expr_l1 -> expr_dq
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 596: // expr_l1 -> question_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 597: // expr_l1 -> new_question_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 598: // expr_l1_for_question_expr -> expr_dq
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 599: // expr_l1_for_question_expr -> question_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 600: // expr_l1_for_new_question_expr -> expr_dq
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 601: // expr_l1_for_new_question_expr -> new_question_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 602: // expr_l1_func_decl_lambda -> expr_l1
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 603: // expr_l1_func_decl_lambda -> func_decl_lambda
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 604: // expr_l1_for_lambda -> expr_dq
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 605: // expr_l1_for_lambda -> question_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 606: // expr_l1_for_lambda -> func_decl_lambda
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 607: // expr_dq -> relop_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 608: // expr_dq -> expr_dq, tkDoubleQuestion, relop_expr
{ CurrentSemanticValue.ex = new double_question_node(ValueStack[ValueStack.Depth-3].ex as expression, ValueStack[ValueStack.Depth-1].ex as expression, CurrentLocationSpan);}
        break;
      case 609: // sizeof_expr -> tkSizeOf, tkRoundOpen, simple_or_template_type_reference, 
                //                tkRoundClose
{ 
			CurrentSemanticValue.ex = new sizeof_operator((named_type_reference)ValueStack[ValueStack.Depth-2].td, null, CurrentLocationSpan);  
		}
        break;
      case 610: // typeof_expr -> tkTypeOf, tkRoundOpen, simple_or_template_type_reference, 
                //                tkRoundClose
{ 
			CurrentSemanticValue.ex = new typeof_operator((named_type_reference)ValueStack[ValueStack.Depth-2].td, CurrentLocationSpan);  
		}
        break;
      case 611: // typeof_expr -> tkTypeOf, tkRoundOpen, empty_template_type_reference, 
                //                tkRoundClose
{ 
			CurrentSemanticValue.ex = new typeof_operator((named_type_reference)ValueStack[ValueStack.Depth-2].td, CurrentLocationSpan);  
		}
        break;
      case 612: // question_expr -> expr_l1_for_question_expr, tkQuestion, 
                //                  expr_l1_for_question_expr, tkColon, 
                //                  expr_l1_for_question_expr
{ 
            if (ValueStack[ValueStack.Depth-3].ex is nil_const && ValueStack[ValueStack.Depth-1].ex is nil_const)
            	parsertools.AddErrorFromResource("TWO_NILS_IN_QUESTION_EXPR",LocationStack[LocationStack.Depth-3]);
			CurrentSemanticValue.ex = new question_colon_expression(ValueStack[ValueStack.Depth-5].ex, ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);  
		}
        break;
      case 613: // new_question_expr -> tkIf, expr_l1_for_new_question_expr, tkThen, 
                //                      expr_l1_for_new_question_expr, tkElse, 
                //                      expr_l1_for_new_question_expr
{ 
        	if (parsertools.build_tree_for_formatter)
        	{
        		CurrentSemanticValue.ex = new if_expr_new(ValueStack[ValueStack.Depth-5].ex, ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);
        	}
        	else
        	{
            	if (ValueStack[ValueStack.Depth-3].ex is nil_const && ValueStack[ValueStack.Depth-1].ex is nil_const)
            		parsertools.AddErrorFromResource("TWO_NILS_IN_QUESTION_EXPR",LocationStack[LocationStack.Depth-3]);
				CurrentSemanticValue.ex = new question_colon_expression(ValueStack[ValueStack.Depth-5].ex, ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);
			}			
		}
        break;
      case 614: // empty_template_type_reference -> simple_type_identifier, 
                //                                  template_type_empty_params
{
            CurrentSemanticValue.td = new template_type_reference((named_type_reference)ValueStack[ValueStack.Depth-2].td, (template_param_list)ValueStack[ValueStack.Depth-1].stn, CurrentLocationSpan); 
        }
        break;
      case 615: // empty_template_type_reference -> simple_type_identifier, tkAmpersend, 
                //                                  template_type_empty_params
{
            CurrentSemanticValue.td = new template_type_reference((named_type_reference)ValueStack[ValueStack.Depth-3].td, (template_param_list)ValueStack[ValueStack.Depth-1].stn, CurrentLocationSpan);
        }
        break;
      case 616: // simple_or_template_type_reference -> simple_type_identifier
{ 
			CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td;
		}
        break;
      case 617: // simple_or_template_type_reference -> simple_type_identifier, 
                //                                      template_type_params
{ 
			CurrentSemanticValue.td = new template_type_reference((named_type_reference)ValueStack[ValueStack.Depth-2].td, (template_param_list)ValueStack[ValueStack.Depth-1].stn, CurrentLocationSpan); 
        }
        break;
      case 618: // simple_or_template_type_reference -> simple_type_identifier, tkAmpersend, 
                //                                      template_type_params
{ 
			CurrentSemanticValue.td = new template_type_reference((named_type_reference)ValueStack[ValueStack.Depth-3].td, (template_param_list)ValueStack[ValueStack.Depth-1].stn, CurrentLocationSpan); 
        }
        break;
      case 619: // optional_array_initializer -> tkRoundOpen, typed_const_list, tkRoundClose
{ 
			CurrentSemanticValue.stn = new array_const((expression_list)ValueStack[ValueStack.Depth-2].stn, CurrentLocationSpan); 
		}
        break;
      case 621: // new_expr -> tkNew, simple_or_template_type_reference, 
                //             optional_expr_list_with_bracket
{
			CurrentSemanticValue.ex = new new_expr(ValueStack[ValueStack.Depth-2].td, ValueStack[ValueStack.Depth-1].stn as expression_list, false, null, CurrentLocationSpan);
        }
        break;
      case 622: // new_expr -> tkNew, simple_or_template_type_reference, tkSquareOpen, 
                //             optional_expr_list, tkSquareClose, optional_array_initializer
{
        	var el = ValueStack[ValueStack.Depth-3].stn as expression_list;
        	if (el == null)
        	{
        		var cnt = 0;
        		var ac = ValueStack[ValueStack.Depth-1].stn as array_const;
        		if (ac != null && ac.elements != null)
	        	    cnt = ac.elements.Count;
	        	else parsertools.AddErrorFromResource("WITHOUT_INIT_AND_SIZE",LocationStack[LocationStack.Depth-2]);
        		el = new expression_list(new int32_const(cnt),LocationStack[LocationStack.Depth-6]);
        	}	
			CurrentSemanticValue.ex = new new_expr(ValueStack[ValueStack.Depth-5].td, el, true, ValueStack[ValueStack.Depth-1].stn as array_const, CurrentLocationSpan);
        }
        break;
      case 623: // new_expr -> tkNew, tkClass, tkRoundOpen, list_fields_in_unnamed_object, 
                //             tkRoundClose
{
        // sugared node	
        	var l = ValueStack[ValueStack.Depth-2].ob as name_assign_expr_list;
        	var exprs = l.name_expr.Select(x=>x.expr).ToList();
        	var typename = "AnonymousType#"+Guid();
        	var type = new named_type_reference(typename,LocationStack[LocationStack.Depth-5]);
        	
			// node new_expr - for code generation of new node
			var ne = new new_expr(type, new expression_list(exprs), CurrentLocationSpan);
			// node unnamed_type_object - for formatting and code generation (new node and Anonymous class)
			CurrentSemanticValue.ex = new unnamed_type_object(l, true, ne, CurrentLocationSpan);
        }
        break;
      case 624: // field_in_unnamed_object -> identifier, tkAssign, relop_expr
{
		    if (ValueStack[ValueStack.Depth-1].ex is nil_const)
				parsertools.AddErrorFromResource("NIL_IN_UNNAMED_OBJECT",CurrentLocationSpan);		    
			CurrentSemanticValue.ob = new name_assign_expr(ValueStack[ValueStack.Depth-3].id,ValueStack[ValueStack.Depth-1].ex,CurrentLocationSpan);
		}
        break;
      case 625: // field_in_unnamed_object -> relop_expr
{
			ident name = null;
			var id = ValueStack[ValueStack.Depth-1].ex as ident;
			dot_node dot;
			if (id != null)
				name = id;
			else 
            {
            	dot = ValueStack[ValueStack.Depth-1].ex as dot_node;
            	if (dot != null)
            	{
            		name = dot.right as ident;
            	}            	
            } 
			if (name == null)
				parsertools.errors.Add(new bad_anon_type(parsertools.CurrentFileName, LocationStack[LocationStack.Depth-1], null));	
			CurrentSemanticValue.ob = new name_assign_expr(name,ValueStack[ValueStack.Depth-1].ex,CurrentLocationSpan);
		}
        break;
      case 626: // list_fields_in_unnamed_object -> field_in_unnamed_object
{
			var l = new name_assign_expr_list();
			CurrentSemanticValue.ob = l.Add(ValueStack[ValueStack.Depth-1].ob as name_assign_expr);
		}
        break;
      case 627: // list_fields_in_unnamed_object -> list_fields_in_unnamed_object, tkComma, 
                //                                  field_in_unnamed_object
{
			var nel = ValueStack[ValueStack.Depth-3].ob as name_assign_expr_list;
			var ss = nel.name_expr.Select(ne=>ne.name.name).FirstOrDefault(x=>string.Compare(x,(ValueStack[ValueStack.Depth-1].ob as name_assign_expr).name.name,true)==0);
            if (ss != null)
            	parsertools.errors.Add(new anon_type_duplicate_name(parsertools.CurrentFileName, LocationStack[LocationStack.Depth-1], null));
			nel.Add(ValueStack[ValueStack.Depth-1].ob as name_assign_expr);
			CurrentSemanticValue.ob = ValueStack[ValueStack.Depth-3].ob;
		}
        break;
      case 628: // optional_expr_list_with_bracket -> /* empty */
{ CurrentSemanticValue.stn = null; }
        break;
      case 629: // optional_expr_list_with_bracket -> tkRoundOpen, optional_expr_list, 
                //                                    tkRoundClose
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-2].stn; }
        break;
      case 630: // relop_expr -> simple_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 631: // relop_expr -> relop_expr, relop, simple_expr
{ 
			CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan); 
		}
        break;
      case 632: // relop_expr -> relop_expr, relop, new_question_expr
{ 
			CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan); 
		}
        break;
      case 633: // relop_expr -> is_type_expr, tkRoundOpen, pattern_out_param_list, tkRoundClose
{
            var isTypeCheck = ValueStack[ValueStack.Depth-4].ex as typecast_node;
            var deconstructorPattern = new deconstructor_pattern(ValueStack[ValueStack.Depth-2].ob as List<pattern_parameter>, isTypeCheck.type_def, null, CurrentLocationSpan); 
            CurrentSemanticValue.ex = new is_pattern_expr(isTypeCheck.expr, deconstructorPattern, CurrentLocationSpan);
        }
        break;
      case 634: // pattern -> simple_or_template_type_reference, tkRoundOpen, 
                //            pattern_out_param_list, tkRoundClose
{ 
            CurrentSemanticValue.stn = new deconstructor_pattern(ValueStack[ValueStack.Depth-2].ob as List<pattern_parameter>, ValueStack[ValueStack.Depth-4].td, null, CurrentLocationSpan); 
        }
        break;
      case 635: // pattern_optional_var -> simple_or_template_type_reference, tkRoundOpen, 
                //                         pattern_out_param_list_optional_var, tkRoundClose
{ 
            CurrentSemanticValue.stn = new deconstructor_pattern(ValueStack[ValueStack.Depth-2].ob as List<pattern_parameter>, ValueStack[ValueStack.Depth-4].td, null, CurrentLocationSpan); 
        }
        break;
      case 636: // deconstruction_or_const_pattern -> simple_or_template_type_reference, 
                //                                    tkRoundOpen, 
                //                                    pattern_out_param_list_optional_var, 
                //                                    tkRoundClose
{ 
            CurrentSemanticValue.stn = new deconstructor_pattern(ValueStack[ValueStack.Depth-2].ob as List<pattern_parameter>, ValueStack[ValueStack.Depth-4].td, null, CurrentLocationSpan); 
        }
        break;
      case 637: // deconstruction_or_const_pattern -> const_pattern_expr_list
{
		    CurrentSemanticValue.stn = new const_pattern(ValueStack[ValueStack.Depth-1].ob as List<syntax_tree_node>, CurrentLocationSpan); 
		}
        break;
      case 638: // const_pattern_expr_list -> const_pattern_expression
{ 
			CurrentSemanticValue.ob = new List<syntax_tree_node>(); 
			(CurrentSemanticValue.ob as List<syntax_tree_node>).Add(ValueStack[ValueStack.Depth-1].stn);
		}
        break;
      case 639: // const_pattern_expr_list -> const_pattern_expr_list, tkComma, 
                //                            const_pattern_expression
{ 
			var list = ValueStack[ValueStack.Depth-3].ob as List<syntax_tree_node>;
            list.Add(ValueStack[ValueStack.Depth-1].stn);
            CurrentSemanticValue.ob = list;
		}
        break;
      case 640: // const_pattern_expression -> literal_or_number
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 641: // const_pattern_expression -> simple_or_template_type_reference
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].td; }
        break;
      case 642: // const_pattern_expression -> tkNil
{ 
			CurrentSemanticValue.stn = new nil_const();  
			CurrentSemanticValue.stn.source_context = CurrentLocationSpan;
		}
        break;
      case 643: // const_pattern_expression -> sizeof_expr
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 644: // const_pattern_expression -> typeof_expr
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 645: // collection_pattern -> tkSquareOpen, collection_pattern_expr_list, tkSquareClose
{
			CurrentSemanticValue.stn = new collection_pattern(ValueStack[ValueStack.Depth-2].ob as List<pattern_parameter>, CurrentLocationSpan);
		}
        break;
      case 646: // collection_pattern_expr_list -> collection_pattern_list_item
{
			CurrentSemanticValue.ob = new List<pattern_parameter>();
            (CurrentSemanticValue.ob as List<pattern_parameter>).Add(ValueStack[ValueStack.Depth-1].stn as pattern_parameter);
		}
        break;
      case 647: // collection_pattern_expr_list -> collection_pattern_expr_list, tkComma, 
                //                                 collection_pattern_list_item
{
			var list = ValueStack[ValueStack.Depth-3].ob as List<pattern_parameter>;
            list.Add(ValueStack[ValueStack.Depth-1].stn as pattern_parameter);
            CurrentSemanticValue.ob = list;
		}
        break;
      case 648: // collection_pattern_list_item -> literal_or_number
{
			CurrentSemanticValue.stn = new const_pattern_parameter(ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);
		}
        break;
      case 649: // collection_pattern_list_item -> collection_pattern_var_item
{
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn;
		}
        break;
      case 650: // collection_pattern_list_item -> tkUnderscore
{
			CurrentSemanticValue.stn = new collection_pattern_wild_card(CurrentLocationSpan);
		}
        break;
      case 651: // collection_pattern_list_item -> pattern_optional_var
{
            CurrentSemanticValue.stn = new recursive_deconstructor_parameter(ValueStack[ValueStack.Depth-1].stn as pattern_node, CurrentLocationSpan);
        }
        break;
      case 652: // collection_pattern_list_item -> collection_pattern
{
			CurrentSemanticValue.stn = new recursive_collection_parameter(ValueStack[ValueStack.Depth-1].stn as pattern_node, CurrentLocationSpan);
		}
        break;
      case 653: // collection_pattern_list_item -> tuple_pattern
{
			CurrentSemanticValue.stn = new recursive_tuple_parameter(ValueStack[ValueStack.Depth-1].stn as pattern_node, CurrentLocationSpan);
		}
        break;
      case 654: // collection_pattern_list_item -> tkDotDot
{
			CurrentSemanticValue.stn = new collection_pattern_gap_parameter(CurrentLocationSpan);
		}
        break;
      case 655: // collection_pattern_var_item -> tkVar, identifier
{
            CurrentSemanticValue.stn = new collection_pattern_var_parameter(ValueStack[ValueStack.Depth-1].id, null, CurrentLocationSpan);
        }
        break;
      case 656: // tuple_pattern -> tkRoundOpen, tuple_pattern_item_list, tkRoundClose
{
			if ((ValueStack[ValueStack.Depth-2].ob as List<pattern_parameter>).Count>6) 
				parsertools.AddErrorFromResource("TUPLE_ELEMENTS_COUNT_MUST_BE_LESSEQUAL_7",CurrentLocationSpan);
			CurrentSemanticValue.stn = new tuple_pattern(ValueStack[ValueStack.Depth-2].ob as List<pattern_parameter>, CurrentLocationSpan);
		}
        break;
      case 657: // tuple_pattern_item -> tkUnderscore
{ 
			CurrentSemanticValue.stn = new tuple_pattern_wild_card(CurrentLocationSpan); 
		}
        break;
      case 658: // tuple_pattern_item -> literal_or_number
{ 
			CurrentSemanticValue.stn = new const_pattern_parameter(ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);
		}
        break;
      case 659: // tuple_pattern_item -> sign, literal_or_number
{
			CurrentSemanticValue.stn = new const_pattern_parameter(new un_expr(ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan), CurrentLocationSpan);
		}
        break;
      case 660: // tuple_pattern_item -> tkVar, identifier
{
            CurrentSemanticValue.stn = new tuple_pattern_var_parameter(ValueStack[ValueStack.Depth-1].id, null, CurrentLocationSpan);
        }
        break;
      case 661: // tuple_pattern_item -> pattern_optional_var
{
            CurrentSemanticValue.stn = new recursive_deconstructor_parameter(ValueStack[ValueStack.Depth-1].stn as pattern_node, CurrentLocationSpan);
        }
        break;
      case 662: // tuple_pattern_item -> collection_pattern
{
			CurrentSemanticValue.stn = new recursive_collection_parameter(ValueStack[ValueStack.Depth-1].stn as pattern_node, CurrentLocationSpan);
		}
        break;
      case 663: // tuple_pattern_item -> tuple_pattern
{
			CurrentSemanticValue.stn = new recursive_tuple_parameter(ValueStack[ValueStack.Depth-1].stn as pattern_node, CurrentLocationSpan);
		}
        break;
      case 664: // tuple_pattern_item_list -> tuple_pattern_item
{ 
			CurrentSemanticValue.ob = new List<pattern_parameter>();
            (CurrentSemanticValue.ob as List<pattern_parameter>).Add(ValueStack[ValueStack.Depth-1].stn as pattern_parameter);
		}
        break;
      case 665: // tuple_pattern_item_list -> tuple_pattern_item_list, tkComma, tuple_pattern_item
{
			var list = ValueStack[ValueStack.Depth-3].ob as List<pattern_parameter>;
            list.Add(ValueStack[ValueStack.Depth-1].stn as pattern_parameter);
            CurrentSemanticValue.ob = list;
		}
        break;
      case 666: // pattern_out_param_list_optional_var -> pattern_out_param_optional_var
{
            CurrentSemanticValue.ob = new List<pattern_parameter>();
            (CurrentSemanticValue.ob as List<pattern_parameter>).Add(ValueStack[ValueStack.Depth-1].stn as pattern_parameter);
        }
        break;
      case 667: // pattern_out_param_list_optional_var -> pattern_out_param_list_optional_var, 
                //                                        tkSemiColon, 
                //                                        pattern_out_param_optional_var
{
            var list = ValueStack[ValueStack.Depth-3].ob as List<pattern_parameter>;
            list.Add(ValueStack[ValueStack.Depth-1].stn as pattern_parameter);
            CurrentSemanticValue.ob = list;
        }
        break;
      case 668: // pattern_out_param_list_optional_var -> pattern_out_param_list_optional_var, 
                //                                        tkComma, 
                //                                        pattern_out_param_optional_var
{
            var list = ValueStack[ValueStack.Depth-3].ob as List<pattern_parameter>;
            list.Add(ValueStack[ValueStack.Depth-1].stn as pattern_parameter);
            CurrentSemanticValue.ob = list;
        }
        break;
      case 669: // pattern_out_param_list -> pattern_out_param
{
            CurrentSemanticValue.ob = new List<pattern_parameter>();
            (CurrentSemanticValue.ob as List<pattern_parameter>).Add(ValueStack[ValueStack.Depth-1].stn as pattern_parameter);
        }
        break;
      case 670: // pattern_out_param_list -> pattern_out_param_list, tkSemiColon, 
                //                           pattern_out_param
{
            var list = ValueStack[ValueStack.Depth-3].ob as List<pattern_parameter>;
            list.Add(ValueStack[ValueStack.Depth-1].stn as pattern_parameter);
            CurrentSemanticValue.ob = list;
        }
        break;
      case 671: // pattern_out_param_list -> pattern_out_param_list, tkComma, pattern_out_param
{
            var list = ValueStack[ValueStack.Depth-3].ob as List<pattern_parameter>;
            list.Add(ValueStack[ValueStack.Depth-1].stn as pattern_parameter);
            CurrentSemanticValue.ob = list;
        }
        break;
      case 672: // pattern_out_param -> tkUnderscore
{
			CurrentSemanticValue.stn = new wild_card_deconstructor_parameter(CurrentLocationSpan);
		}
        break;
      case 673: // pattern_out_param -> literal_or_number
{
			CurrentSemanticValue.stn = new const_pattern_parameter(ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);
		}
        break;
      case 674: // pattern_out_param -> tkVar, identifier, tkColon, type_ref
{
            CurrentSemanticValue.stn = new var_deconstructor_parameter(ValueStack[ValueStack.Depth-3].id, ValueStack[ValueStack.Depth-1].td, true, CurrentLocationSpan);
        }
        break;
      case 675: // pattern_out_param -> tkVar, identifier
{
            CurrentSemanticValue.stn = new var_deconstructor_parameter(ValueStack[ValueStack.Depth-1].id, null, true, CurrentLocationSpan);
        }
        break;
      case 676: // pattern_out_param -> pattern
{
            CurrentSemanticValue.stn = new recursive_deconstructor_parameter(ValueStack[ValueStack.Depth-1].stn as pattern_node, CurrentLocationSpan);
        }
        break;
      case 677: // pattern_out_param -> collection_pattern
{
			CurrentSemanticValue.stn = new recursive_collection_parameter(ValueStack[ValueStack.Depth-1].stn as pattern_node, CurrentLocationSpan);
		}
        break;
      case 678: // pattern_out_param -> tuple_pattern
{
			CurrentSemanticValue.stn = new recursive_tuple_parameter(ValueStack[ValueStack.Depth-1].stn as pattern_node, CurrentLocationSpan);
		}
        break;
      case 679: // pattern_out_param_optional_var -> tkUnderscore
{
			CurrentSemanticValue.stn = new wild_card_deconstructor_parameter(CurrentLocationSpan);
		}
        break;
      case 680: // pattern_out_param_optional_var -> literal_or_number
{
			CurrentSemanticValue.stn = new const_pattern_parameter(ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);
		}
        break;
      case 681: // pattern_out_param_optional_var -> sign, literal_or_number
{
			CurrentSemanticValue.stn = new const_pattern_parameter(new un_expr(ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan), CurrentLocationSpan);
		}
        break;
      case 682: // pattern_out_param_optional_var -> identifier, tkColon, type_ref
{
            CurrentSemanticValue.stn = new var_deconstructor_parameter(ValueStack[ValueStack.Depth-3].id, ValueStack[ValueStack.Depth-1].td, false, CurrentLocationSpan);
        }
        break;
      case 683: // pattern_out_param_optional_var -> identifier
{
            CurrentSemanticValue.stn = new var_deconstructor_parameter(ValueStack[ValueStack.Depth-1].id, null, false, CurrentLocationSpan);
        }
        break;
      case 684: // pattern_out_param_optional_var -> tkVar, identifier, tkColon, type_ref
{
            CurrentSemanticValue.stn = new var_deconstructor_parameter(ValueStack[ValueStack.Depth-3].id, ValueStack[ValueStack.Depth-1].td, true, CurrentLocationSpan);
        }
        break;
      case 685: // pattern_out_param_optional_var -> tkVar, identifier
{
            CurrentSemanticValue.stn = new var_deconstructor_parameter(ValueStack[ValueStack.Depth-1].id, null, true, CurrentLocationSpan);
        }
        break;
      case 686: // pattern_out_param_optional_var -> pattern_optional_var
{
            CurrentSemanticValue.stn = new recursive_deconstructor_parameter(ValueStack[ValueStack.Depth-1].stn as pattern_node, CurrentLocationSpan);
        }
        break;
      case 687: // pattern_out_param_optional_var -> collection_pattern
{
			CurrentSemanticValue.stn = new recursive_collection_parameter(ValueStack[ValueStack.Depth-1].stn as pattern_node, CurrentLocationSpan);
		}
        break;
      case 688: // pattern_out_param_optional_var -> tuple_pattern
{
			CurrentSemanticValue.stn = new recursive_tuple_parameter(ValueStack[ValueStack.Depth-1].stn as pattern_node, CurrentLocationSpan);
		}
        break;
      case 689: // simple_expr_or_nothing -> simple_expr
{
		CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex;
	}
        break;
      case 690: // simple_expr_or_nothing -> /* empty */
{
		CurrentSemanticValue.ex = null;
	}
        break;
      case 691: // const_expr_or_nothing -> const_expr
{
		CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex;
	}
        break;
      case 692: // const_expr_or_nothing -> /* empty */
{
		CurrentSemanticValue.ex = null;
	}
        break;
      case 693: // format_expr -> simple_expr, tkColon, simple_expr_or_nothing
{
			CurrentSemanticValue.ex = new format_expr(ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, null, CurrentLocationSpan); 
		}
        break;
      case 694: // format_expr -> tkColon, simple_expr_or_nothing
{ 
			CurrentSemanticValue.ex = new format_expr(null, ValueStack[ValueStack.Depth-1].ex, null, CurrentLocationSpan); 
		}
        break;
      case 695: // format_expr -> simple_expr, tkColon, simple_expr_or_nothing, tkColon, 
                //                simple_expr
{ 
			CurrentSemanticValue.ex = new format_expr(ValueStack[ValueStack.Depth-5].ex, ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan); 
		}
        break;
      case 696: // format_expr -> tkColon, simple_expr_or_nothing, tkColon, simple_expr
{ 
			CurrentSemanticValue.ex = new format_expr(null, ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan); 
		}
        break;
      case 697: // format_const_expr -> const_expr, tkColon, const_expr_or_nothing
{ 
			CurrentSemanticValue.ex = new format_expr(ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, null, CurrentLocationSpan); 
		}
        break;
      case 698: // format_const_expr -> tkColon, const_expr_or_nothing
{ 
			CurrentSemanticValue.ex = new format_expr(null, ValueStack[ValueStack.Depth-1].ex, null, CurrentLocationSpan); 
		}
        break;
      case 699: // format_const_expr -> const_expr, tkColon, const_expr_or_nothing, tkColon, 
                //                      const_expr
{ 
			CurrentSemanticValue.ex = new format_expr(ValueStack[ValueStack.Depth-5].ex, ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan); 
		}
        break;
      case 700: // format_const_expr -> tkColon, const_expr_or_nothing, tkColon, const_expr
{ 
			CurrentSemanticValue.ex = new format_expr(null, ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan); 
		}
        break;
      case 701: // relop -> tkEqual
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 702: // relop -> tkNotEqual
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 703: // relop -> tkLower
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 704: // relop -> tkGreater
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 705: // relop -> tkLowerEqual
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 706: // relop -> tkGreaterEqual
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 707: // relop -> tkIn
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 708: // simple_expr -> term1
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 709: // simple_expr -> simple_expr, tkDotDot, term1
{ 
		if (parsertools.build_tree_for_formatter)
			CurrentSemanticValue.ex = new diapason_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,CurrentLocationSpan);
		else 
			CurrentSemanticValue.ex = new diapason_expr_new(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,CurrentLocationSpan); 
	}
        break;
      case 710: // term1 -> term
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 711: // term1 -> term1, addop, term
{ 
			CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan); 
		}
        break;
      case 712: // term1 -> term1, addop, new_question_expr
{ 
			CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan); 
		}
        break;
      case 713: // addop -> tkPlus
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 714: // addop -> tkMinus
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 715: // addop -> tkOr
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 716: // addop -> tkXor
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 717: // addop -> tkCSharpStyleOr
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 718: // typecast_op -> tkAs
{ 
			CurrentSemanticValue.ob = op_typecast.as_op; 
		}
        break;
      case 719: // typecast_op -> tkIs
{ 
			CurrentSemanticValue.ob = op_typecast.is_op; 
		}
        break;
      case 720: // as_is_expr -> is_type_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 721: // as_is_expr -> as_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 722: // as_expr -> term, tkAs, simple_or_template_type_reference
{
            CurrentSemanticValue.ex = NewAsIsExpr(ValueStack[ValueStack.Depth-3].ex, op_typecast.as_op, ValueStack[ValueStack.Depth-1].td, CurrentLocationSpan);
        }
        break;
      case 723: // as_expr -> term, tkAs, array_type
{
            CurrentSemanticValue.ex = NewAsIsExpr(ValueStack[ValueStack.Depth-3].ex, op_typecast.as_op, ValueStack[ValueStack.Depth-1].td, CurrentLocationSpan);
	    }
        break;
      case 724: // is_type_expr -> term, tkIs, simple_or_template_type_reference
{
            CurrentSemanticValue.ex = NewAsIsExpr(ValueStack[ValueStack.Depth-3].ex, op_typecast.is_op, ValueStack[ValueStack.Depth-1].td, CurrentLocationSpan);
        }
        break;
      case 725: // is_type_expr -> term, tkIs, array_type
{
            CurrentSemanticValue.ex = NewAsIsExpr(ValueStack[ValueStack.Depth-3].ex, op_typecast.as_op, ValueStack[ValueStack.Depth-1].td, CurrentLocationSpan);
	    }
        break;
      case 726: // power_expr -> factor_without_unary_op, tkStarStar, factor
{ CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,(ValueStack[ValueStack.Depth-2].op).type, CurrentLocationSpan); }
        break;
      case 727: // power_expr -> factor_without_unary_op, tkStarStar, power_expr
{ CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,(ValueStack[ValueStack.Depth-2].op).type, CurrentLocationSpan); }
        break;
      case 728: // power_expr -> sign, power_expr
{ CurrentSemanticValue.ex = new un_expr(ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan); }
        break;
      case 729: // term -> factor
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 730: // term -> new_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 731: // term -> power_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 732: // term -> term, mulop, factor
{ CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,(ValueStack[ValueStack.Depth-2].op).type, CurrentLocationSpan); }
        break;
      case 733: // term -> term, mulop, power_expr
{ CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,(ValueStack[ValueStack.Depth-2].op).type, CurrentLocationSpan); }
        break;
      case 734: // term -> term, mulop, new_question_expr
{ CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,(ValueStack[ValueStack.Depth-2].op).type, CurrentLocationSpan); }
        break;
      case 735: // term -> as_is_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 736: // mulop -> tkStar
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 737: // mulop -> tkSlash
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 738: // mulop -> tkDiv
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 739: // mulop -> tkMod
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 740: // mulop -> tkShl
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 741: // mulop -> tkShr
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 742: // mulop -> tkAnd
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 743: // default_expr -> tkDefault, tkRoundOpen, simple_or_template_type_reference, 
                //                 tkRoundClose
{ 
			CurrentSemanticValue.ex = new default_operator(ValueStack[ValueStack.Depth-2].td as named_type_reference, CurrentLocationSpan);  
		}
        break;
      case 744: // tuple -> tkRoundOpen, expr_l1_or_unpacked, tkComma, expr_l1_or_unpacked_list, 
                //          lambda_type_ref, optional_full_lambda_fp_list, tkRoundClose
{
			if (ValueStack[ValueStack.Depth-6].ex is unpacked_list_of_ident_or_list) 
				parsertools.AddErrorFromResource("EXPRESSION_EXPECTED",LocationStack[LocationStack.Depth-6]);
			foreach (var ex in (ValueStack[ValueStack.Depth-4].stn as expression_list).expressions)
				if (ex is unpacked_list_of_ident_or_list)
					parsertools.AddErrorFromResource("EXPRESSION_EXPECTED",ex.source_context);
			/*if ($5 != null) 
				parsertools.AddErrorFromResource("BAD_TUPLE",@5);
			if ($6 != null) 
				parsertools.AddErrorFromResource("BAD_TUPLE",@6);*/

			if ((ValueStack[ValueStack.Depth-4].stn as expression_list).Count>6) 
				parsertools.AddErrorFromResource("TUPLE_ELEMENTS_COUNT_MUST_BE_LESSEQUAL_7",CurrentLocationSpan);
            (ValueStack[ValueStack.Depth-4].stn as expression_list).Insert(0,ValueStack[ValueStack.Depth-6].ex);
			CurrentSemanticValue.ex = new tuple_node(ValueStack[ValueStack.Depth-4].stn as expression_list,CurrentLocationSpan);
		}
        break;
      case 745: // factor_without_unary_op -> literal_or_number
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 746: // factor_without_unary_op -> var_reference
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 747: // factor -> tkNil
{ 
			CurrentSemanticValue.ex = new nil_const();  
			CurrentSemanticValue.ex.source_context = CurrentLocationSpan;
		}
        break;
      case 748: // factor -> literal_or_number
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 749: // factor -> default_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 750: // factor -> tkSquareOpen, elem_list, tkSquareClose
{ 
			CurrentSemanticValue.ex = new pascal_set_constant(ValueStack[ValueStack.Depth-2].stn as expression_list, CurrentLocationSpan);  
		}
        break;
      case 751: // factor -> tkNot, factor
{ 
			CurrentSemanticValue.ex = new un_expr(ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan); 
		}
        break;
      case 752: // factor -> sign, factor
{
			if (ValueStack[ValueStack.Depth-2].op.type == Operators.Minus)
			{
			    var i64 = ValueStack[ValueStack.Depth-1].ex as int64_const;
				if (i64 != null && i64.val == (Int64)Int32.MaxValue + 1)
				{
					CurrentSemanticValue.ex = new int32_const(Int32.MinValue,CurrentLocationSpan);
					break;
				}
				var ui64 = ValueStack[ValueStack.Depth-1].ex as uint64_const;
				if (ui64 != null && ui64.val == (UInt64)Int64.MaxValue + 1)
				{
					CurrentSemanticValue.ex = new int64_const(Int64.MinValue,CurrentLocationSpan);
					break;
				}
				if (ui64 != null && ui64.val > (UInt64)Int64.MaxValue + 1)
				{
					parsertools.AddErrorFromResource("BAD_INT2",CurrentLocationSpan);
					break;
				}
			    // ����� ������� ���������� ��������� � �������������� �������
			}
			CurrentSemanticValue.ex = new un_expr(ValueStack[ValueStack.Depth-1].ex, ValueStack[ValueStack.Depth-2].op.type, CurrentLocationSpan);
		}
        break;
      case 753: // factor -> tkDeref, factor
{
            CurrentSemanticValue.ex = new index(ValueStack[ValueStack.Depth-1].ex, true, CurrentLocationSpan);
        }
        break;
      case 754: // factor -> var_reference
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 755: // factor -> tuple
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 756: // literal_or_number -> literal
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 757: // literal_or_number -> unsigned_number
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 758: // var_question_point -> variable, tkQuestionPoint, variable
{
		CurrentSemanticValue.ex = new dot_question_node(ValueStack[ValueStack.Depth-3].ex as addressed_value,ValueStack[ValueStack.Depth-1].ex as addressed_value,CurrentLocationSpan);
	}
        break;
      case 759: // var_question_point -> variable, tkQuestionPoint, var_question_point
{
		CurrentSemanticValue.ex = new dot_question_node(ValueStack[ValueStack.Depth-3].ex as addressed_value,ValueStack[ValueStack.Depth-1].ex as addressed_value,CurrentLocationSpan);
	}
        break;
      case 760: // var_reference -> var_address, variable
{
			CurrentSemanticValue.ex = NewVarReference(ValueStack[ValueStack.Depth-2].stn as get_address, ValueStack[ValueStack.Depth-1].ex as addressed_value, CurrentLocationSpan);
		}
        break;
      case 761: // var_reference -> variable
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 762: // var_reference -> var_question_point
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 763: // var_address -> tkAddressOf
{ 
			CurrentSemanticValue.stn = NewVarAddress(CurrentLocationSpan);
		}
        break;
      case 764: // var_address -> var_address, tkAddressOf
{ 
			CurrentSemanticValue.stn = NewVarAddress(ValueStack[ValueStack.Depth-2].stn as get_address, CurrentLocationSpan);
		}
        break;
      case 765: // attribute_variable -> simple_type_identifier, optional_expr_list_with_bracket
{ 
			CurrentSemanticValue.stn = new attribute(null, ValueStack[ValueStack.Depth-2].td as named_type_reference, ValueStack[ValueStack.Depth-1].stn as expression_list, CurrentLocationSpan);
		}
        break;
      case 766: // attribute_variable -> template_type, optional_expr_list_with_bracket
{
            CurrentSemanticValue.stn = new attribute(null, ValueStack[ValueStack.Depth-2].td as named_type_reference, ValueStack[ValueStack.Depth-1].stn as expression_list, CurrentLocationSpan);
        }
        break;
      case 767: // dotted_identifier -> identifier
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 768: // dotted_identifier -> dotted_identifier, tkPoint, identifier_or_keyword
{
			CurrentSemanticValue.ex = new dot_node(ValueStack[ValueStack.Depth-3].ex as addressed_value, ValueStack[ValueStack.Depth-1].id as addressed_value, CurrentLocationSpan);
		}
        break;
      case 769: // variable_as_type -> dotted_identifier
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex;}
        break;
      case 770: // variable_as_type -> dotted_identifier, template_type_params
{ CurrentSemanticValue.ex = new ident_with_templateparams(ValueStack[ValueStack.Depth-2].ex as addressed_value, ValueStack[ValueStack.Depth-1].stn as template_param_list, CurrentLocationSpan);   }
        break;
      case 771: // variable_or_literal_or_number -> variable
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 772: // variable_or_literal_or_number -> literal_or_number
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 773: // var_with_init_for_expr_with_let -> tkVar, identifier, tkAssign, expr, 
                //                                    tkSemiColon
{
			CurrentSemanticValue.stn = new assign(ValueStack[ValueStack.Depth-4].id as addressed_value, ValueStack[ValueStack.Depth-2].ex, Operators.Assignment, CurrentLocationSpan);
		}
        break;
      case 774: // var_with_init_for_expr_with_let_list -> var_with_init_for_expr_with_let
{
			CurrentSemanticValue.stn = new statement_list(ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan);
		}
        break;
      case 775: // var_with_init_for_expr_with_let_list -> var_with_init_for_expr_with_let_list, 
                //                                         var_with_init_for_expr_with_let
{
			ValueStack[ValueStack.Depth-2].stn = new statement_list(ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan);
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-2].stn;
		}
        break;
      case 776: // variable -> identifier
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 777: // variable -> operator_name_ident
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 778: // variable -> tkInherited, identifier
{ 
			CurrentSemanticValue.ex = new inherited_ident(ValueStack[ValueStack.Depth-1].id.name, CurrentLocationSpan);
		}
        break;
      case 779: // variable -> tkRoundOpen, expr, tkRoundClose
{
		    if (!parsertools.build_tree_for_formatter) 
            {
                ValueStack[ValueStack.Depth-2].ex.source_context = CurrentLocationSpan;
                CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-2].ex;
            } 
			else CurrentSemanticValue.ex = new bracket_expr(ValueStack[ValueStack.Depth-2].ex, CurrentLocationSpan);
        }
        break;
      case 780: // variable -> tkRoundOpen, var_with_init_for_expr_with_let_list, expr, 
                //             tkRoundClose
{
		    if (!parsertools.build_tree_for_formatter) 
            {
                ValueStack[ValueStack.Depth-2].ex.source_context = CurrentLocationSpan;
                CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-2].ex;
            } 
			else CurrentSemanticValue.ex = new expression_with_let(ValueStack[ValueStack.Depth-3].stn as statement_list, ValueStack[ValueStack.Depth-3].stn as expression, CurrentLocationSpan);
		}
        break;
      case 781: // variable -> sizeof_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 782: // variable -> typeof_expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 783: // variable -> literal_or_number, tkPoint, identifier_or_keyword
{ 
			CurrentSemanticValue.ex = new dot_node(ValueStack[ValueStack.Depth-3].ex as addressed_value, ValueStack[ValueStack.Depth-1].id as addressed_value, CurrentLocationSpan); 
		}
        break;
      case 784: // variable -> variable_or_literal_or_number, tkSquareOpen, expr_list, 
                //             tkSquareClose
{
        	var el = ValueStack[ValueStack.Depth-2].stn as expression_list; // SSM 10/03/16
        	if (el.Count==1 && el.expressions[0] is format_expr) 
        	{
        		var fe = el.expressions[0] as format_expr;
                if (!parsertools.build_tree_for_formatter)
                {
                    if (fe.expr == null)
                        fe.expr = new int32_const(int.MaxValue,LocationStack[LocationStack.Depth-2]);
                    if (fe.format1 == null)
                        fe.format1 = new int32_const(int.MaxValue,LocationStack[LocationStack.Depth-2]);
                }
        		CurrentSemanticValue.ex = new slice_expr(ValueStack[ValueStack.Depth-4].ex as addressed_value,fe.expr,fe.format1,fe.format2,CurrentLocationSpan);
			}   
			// ����������� �����
            else if (el.expressions.Any(e => e is format_expr))
            {
            	if (el.expressions.Count > 4)
            		parsertools.AddErrorFromResource("SLICES_OF MULTIDIMENSIONAL_ARRAYS_ALLOW_ONLY_FOR_RANK_LT_5",CurrentLocationSpan); // ����� ����������� �������� ��������� ������ ��� �������� ����������� < 5  
                var ll = new List<Tuple<expression, expression, expression>>();
                foreach (var ex in el.expressions)
                {
                    if (ex is format_expr fe)
                    {
                        if (fe.expr == null)
                            fe.expr = new int32_const(int.MaxValue, fe.source_context);
                        if (fe.format1 == null)
                            fe.format1 = new int32_const(int.MaxValue, fe.source_context);
                        if (fe.format2 == null)
                            fe.format2 = new int32_const(1, fe.source_context);
                        ll.Add(Tuple.Create(fe.expr, fe.format1, fe.format2));
                    }
                    else
                    {
                    	ll.Add(Tuple.Create(ex, (expression)new int32_const(0, ex.source_context), (expression)new int32_const(int.MaxValue, ex.source_context))); // ��������� �������� ������ �����
                    }
				}
				var sle = new slice_expr(ValueStack[ValueStack.Depth-4].ex as addressed_value,null,null,null,CurrentLocationSpan);
				sle.slices = ll;
				CurrentSemanticValue.ex = sle;
            }
			else CurrentSemanticValue.ex = new indexer(ValueStack[ValueStack.Depth-4].ex as addressed_value, el, CurrentLocationSpan);
        }
        break;
      case 785: // variable -> variable_or_literal_or_number, tkQuestionSquareOpen, format_expr, 
                //             tkSquareClose
{
        	var fe = ValueStack[ValueStack.Depth-2].ex as format_expr; // SSM 9/01/17
            if (!parsertools.build_tree_for_formatter)
            {
                if (fe.expr == null)
                    fe.expr = new int32_const(int.MaxValue,LocationStack[LocationStack.Depth-2]);
                if (fe.format1 == null)
                    fe.format1 = new int32_const(int.MaxValue,LocationStack[LocationStack.Depth-2]);
            }
      		CurrentSemanticValue.ex = new slice_expr_question(ValueStack[ValueStack.Depth-4].ex as addressed_value,fe.expr,fe.format1,fe.format2,CurrentLocationSpan);
        }
        break;
      case 786: // variable -> tkVertParen, elem_list, tkVertParen
{ 
			CurrentSemanticValue.ex = new array_const_new(ValueStack[ValueStack.Depth-2].stn as expression_list, CurrentLocationSpan);  
		}
        break;
      case 787: // variable -> variable, tkRoundOpen, optional_expr_list, tkRoundClose
{
			CurrentSemanticValue.ex = new method_call(ValueStack[ValueStack.Depth-4].ex as addressed_value,ValueStack[ValueStack.Depth-2].stn as expression_list, CurrentLocationSpan);
        }
        break;
      case 788: // variable -> variable, tkPoint, identifier_keyword_operatorname
{
			CurrentSemanticValue.ex = new dot_node(ValueStack[ValueStack.Depth-3].ex as addressed_value, ValueStack[ValueStack.Depth-1].id as addressed_value, CurrentLocationSpan);
        }
        break;
      case 789: // variable -> tuple, tkPoint, identifier_keyword_operatorname
{
			CurrentSemanticValue.ex = new dot_node(ValueStack[ValueStack.Depth-3].ex as addressed_value, ValueStack[ValueStack.Depth-1].id as addressed_value, CurrentLocationSpan);
        }
        break;
      case 790: // variable -> variable, tkDeref
{
			CurrentSemanticValue.ex = new roof_dereference(ValueStack[ValueStack.Depth-2].ex as addressed_value,CurrentLocationSpan);
        }
        break;
      case 791: // variable -> variable, tkAmpersend, template_type_params
{
			CurrentSemanticValue.ex = new ident_with_templateparams(ValueStack[ValueStack.Depth-3].ex as addressed_value, ValueStack[ValueStack.Depth-1].stn as template_param_list, CurrentLocationSpan);
        }
        break;
      case 792: // optional_expr_list -> expr_list
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 793: // optional_expr_list -> /* empty */
{ CurrentSemanticValue.stn = null; }
        break;
      case 794: // elem_list -> elem_list1
{ CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; }
        break;
      case 795: // elem_list -> /* empty */
{ CurrentSemanticValue.stn = null; }
        break;
      case 796: // elem_list1 -> elem
{ 
			CurrentSemanticValue.stn = new expression_list(ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan); 
		}
        break;
      case 797: // elem_list1 -> elem_list1, tkComma, elem
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as expression_list).Add(ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan);
		}
        break;
      case 798: // elem -> expr
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 799: // elem -> expr, tkDotDot, expr
{ CurrentSemanticValue.ex = new diapason_expr(ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan); }
        break;
      case 800: // one_literal -> tkStringLiteral
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].stn as literal; }
        break;
      case 801: // one_literal -> tkAsciiChar
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].stn as literal; }
        break;
      case 802: // literal -> literal_list
{ 
			CurrentSemanticValue.ex = NewLiteral(ValueStack[ValueStack.Depth-1].stn as literal_const_line);
        }
        break;
      case 803: // literal -> tkFormatStringLiteral
{
            if (parsertools.build_tree_for_formatter)
   			{
                CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].stn as string_const;
            }
            else
            {
                CurrentSemanticValue.ex = NewFormatString(ValueStack[ValueStack.Depth-1].stn as string_const);
            }
        }
        break;
      case 804: // literal_list -> one_literal
{ 
			CurrentSemanticValue.stn = new literal_const_line(ValueStack[ValueStack.Depth-1].ex as literal, CurrentLocationSpan);
        }
        break;
      case 805: // literal_list -> literal_list, one_literal
{ 
        	var line = ValueStack[ValueStack.Depth-2].stn as literal_const_line;
            if (line.literals.Last() is string_const && ValueStack[ValueStack.Depth-1].ex is string_const)
            	parsertools.AddErrorFromResource("TWO_STRING_LITERALS_IN_SUCCESSION",LocationStack[LocationStack.Depth-1]);
			CurrentSemanticValue.stn = line.Add(ValueStack[ValueStack.Depth-1].ex as literal, CurrentLocationSpan);
        }
        break;
      case 806: // operator_name_ident -> tkOperator, overload_operator
{ 
			CurrentSemanticValue.ex = new operator_name_ident((ValueStack[ValueStack.Depth-1].op as op_type_node).text, (ValueStack[ValueStack.Depth-1].op as op_type_node).type, CurrentLocationSpan);
		}
        break;
      case 807: // optional_method_modificators -> tkSemiColon
{ 
			CurrentSemanticValue.stn = new procedure_attributes_list(new List<procedure_attribute>(),CurrentLocationSpan); 
		}
        break;
      case 808: // optional_method_modificators -> tkSemiColon, meth_modificators, tkSemiColon
{ 
			//parsertools.AddModifier((procedure_attributes_list)$2, proc_attribute.attr_overload); 
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-2].stn; 
		}
        break;
      case 809: // optional_method_modificators1 -> /* empty */
{ 
			CurrentSemanticValue.stn = new procedure_attributes_list(new List<procedure_attribute>(),CurrentLocationSpan); 
		}
        break;
      case 810: // optional_method_modificators1 -> tkSemiColon, meth_modificators
{ 
			//parsertools.AddModifier((procedure_attributes_list)$2, proc_attribute.attr_overload); 
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; 
		}
        break;
      case 811: // meth_modificators -> meth_modificator
{ 
			CurrentSemanticValue.stn = new procedure_attributes_list(ValueStack[ValueStack.Depth-1].id as procedure_attribute, CurrentLocationSpan); 
		}
        break;
      case 812: // meth_modificators -> meth_modificators, tkSemiColon, meth_modificator
{ 
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as procedure_attributes_list).Add(ValueStack[ValueStack.Depth-1].id as procedure_attribute, CurrentLocationSpan);  
		}
        break;
      case 813: // identifier -> tkIdentifier
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 814: // identifier -> property_specifier_directives
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 815: // identifier -> non_reserved
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 816: // identifier_or_keyword -> identifier
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 817: // identifier_or_keyword -> keyword
{ CurrentSemanticValue.id = new ident(ValueStack[ValueStack.Depth-1].ti.text, CurrentLocationSpan); }
        break;
      case 818: // identifier_or_keyword -> reserved_keyword
{ CurrentSemanticValue.id = new ident(ValueStack[ValueStack.Depth-1].ti.text, CurrentLocationSpan); }
        break;
      case 819: // identifier_keyword_operatorname -> identifier
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 820: // identifier_keyword_operatorname -> keyword
{ CurrentSemanticValue.id = new ident(ValueStack[ValueStack.Depth-1].ti.text, CurrentLocationSpan); }
        break;
      case 821: // identifier_keyword_operatorname -> operator_name_ident
{ CurrentSemanticValue.id = (ident)ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 822: // meth_modificator -> tkAbstract
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 823: // meth_modificator -> tkOverload
{ 
            CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id;
            parsertools.AddWarningFromResource("OVERLOAD_IS_NOT_USED", ValueStack[ValueStack.Depth-1].id.source_context);
        }
        break;
      case 824: // meth_modificator -> tkReintroduce
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 825: // meth_modificator -> tkOverride
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 826: // meth_modificator -> tkExtensionMethod
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 827: // meth_modificator -> tkVirtual
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 828: // property_modificator -> tkVirtual
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 829: // property_modificator -> tkOverride
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 830: // property_modificator -> tkAbstract
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 831: // property_modificator -> tkReintroduce
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 832: // property_specifier_directives -> tkRead
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 833: // property_specifier_directives -> tkWrite
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 834: // non_reserved -> tkName
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 835: // non_reserved -> tkNew
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 836: // visibility_specifier -> tkInternal
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 837: // visibility_specifier -> tkPublic
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 838: // visibility_specifier -> tkProtected
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 839: // visibility_specifier -> tkPrivate
{ CurrentSemanticValue.id = ValueStack[ValueStack.Depth-1].id; }
        break;
      case 840: // keyword -> visibility_specifier
{ 
			CurrentSemanticValue.ti = new token_info(ValueStack[ValueStack.Depth-1].id.name, CurrentLocationSpan);  
		}
        break;
      case 841: // keyword -> tkSealed
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 842: // keyword -> tkTemplate
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 843: // keyword -> tkOr
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 844: // keyword -> tkTypeOf
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 845: // keyword -> tkSizeOf
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 846: // keyword -> tkDefault
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 847: // keyword -> tkWhere
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 848: // keyword -> tkXor
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 849: // keyword -> tkAnd
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 850: // keyword -> tkDiv
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 851: // keyword -> tkMod
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 852: // keyword -> tkShl
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 853: // keyword -> tkShr
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 854: // keyword -> tkNot
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 855: // keyword -> tkAs
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 856: // keyword -> tkIn
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 857: // keyword -> tkIs
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 858: // keyword -> tkArray
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 859: // keyword -> tkSequence
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 860: // keyword -> tkBegin
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 861: // keyword -> tkCase
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 862: // keyword -> tkClass
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 863: // keyword -> tkConst
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 864: // keyword -> tkConstructor
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 865: // keyword -> tkDestructor
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 866: // keyword -> tkDownto
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 867: // keyword -> tkDo
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 868: // keyword -> tkElse
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 869: // keyword -> tkEnd
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 870: // keyword -> tkExcept
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 871: // keyword -> tkFile
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 872: // keyword -> tkAuto
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 873: // keyword -> tkFinalization
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 874: // keyword -> tkFinally
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 875: // keyword -> tkFor
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 876: // keyword -> tkForeach
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 877: // keyword -> tkFunction
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 878: // keyword -> tkIf
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 879: // keyword -> tkImplementation
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 880: // keyword -> tkInherited
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 881: // keyword -> tkInitialization
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 882: // keyword -> tkInterface
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 883: // keyword -> tkProcedure
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 884: // keyword -> tkProperty
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 885: // keyword -> tkRaise
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 886: // keyword -> tkRecord
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 887: // keyword -> tkRepeat
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 888: // keyword -> tkSet
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 889: // keyword -> tkTry
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 890: // keyword -> tkType
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 891: // keyword -> tkStatic
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 892: // keyword -> tkThen
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 893: // keyword -> tkTo
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 894: // keyword -> tkUntil
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 895: // keyword -> tkUses
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 896: // keyword -> tkVar
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 897: // keyword -> tkWhile
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 898: // keyword -> tkWith
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 899: // keyword -> tkNil
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 900: // keyword -> tkGoto
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 901: // keyword -> tkOf
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 902: // keyword -> tkLabel
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 903: // keyword -> tkProgram
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 904: // keyword -> tkUnit
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 905: // keyword -> tkLibrary
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 906: // keyword -> tkNamespace
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 907: // keyword -> tkExternal
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 908: // keyword -> tkParams
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 909: // keyword -> tkEvent
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 910: // keyword -> tkYield
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 911: // keyword -> tkMatch
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 912: // keyword -> tkWhen
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 913: // keyword -> tkPartial
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 914: // keyword -> tkAbstract
{ CurrentSemanticValue.ti = new token_info(ValueStack[ValueStack.Depth-1].id.name, CurrentLocationSpan);  }
        break;
      case 915: // keyword -> tkLock
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 916: // keyword -> tkImplicit
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 917: // keyword -> tkExplicit
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 918: // keyword -> tkOn
{ CurrentSemanticValue.ti = new token_info(ValueStack[ValueStack.Depth-1].id.name, CurrentLocationSpan);  }
        break;
      case 919: // keyword -> tkVirtual
{ CurrentSemanticValue.ti = new token_info(ValueStack[ValueStack.Depth-1].id.name, CurrentLocationSpan);  }
        break;
      case 920: // keyword -> tkOverride
{ CurrentSemanticValue.ti = new token_info(ValueStack[ValueStack.Depth-1].id.name, CurrentLocationSpan);  }
        break;
      case 921: // keyword -> tkLoop
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 922: // keyword -> tkExtensionMethod
{ CurrentSemanticValue.ti = new token_info(ValueStack[ValueStack.Depth-1].id.name, CurrentLocationSpan);  }
        break;
      case 923: // keyword -> tkOverload
{ CurrentSemanticValue.ti = new token_info(ValueStack[ValueStack.Depth-1].id.name, CurrentLocationSpan);  }
        break;
      case 924: // keyword -> tkReintroduce
{ CurrentSemanticValue.ti = new token_info(ValueStack[ValueStack.Depth-1].id.name, CurrentLocationSpan);  }
        break;
      case 925: // keyword -> tkForward
{ CurrentSemanticValue.ti = new token_info(ValueStack[ValueStack.Depth-1].id.name, CurrentLocationSpan);  }
        break;
      case 926: // reserved_keyword -> tkOperator
{ CurrentSemanticValue.ti = ValueStack[ValueStack.Depth-1].ti; }
        break;
      case 927: // overload_operator -> tkMinus
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 928: // overload_operator -> tkPlus
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 929: // overload_operator -> tkSlash
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 930: // overload_operator -> tkStar
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 931: // overload_operator -> tkEqual
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 932: // overload_operator -> tkGreater
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 933: // overload_operator -> tkGreaterEqual
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 934: // overload_operator -> tkLower
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 935: // overload_operator -> tkLowerEqual
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 936: // overload_operator -> tkNotEqual
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 937: // overload_operator -> tkOr
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 938: // overload_operator -> tkXor
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 939: // overload_operator -> tkAnd
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 940: // overload_operator -> tkDiv
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 941: // overload_operator -> tkMod
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 942: // overload_operator -> tkShl
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 943: // overload_operator -> tkShr
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 944: // overload_operator -> tkNot
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 945: // overload_operator -> tkIn
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 946: // overload_operator -> tkImplicit
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 947: // overload_operator -> tkExplicit
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 948: // overload_operator -> assign_operator
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 949: // overload_operator -> tkStarStar
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 950: // assign_operator -> tkAssign
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 951: // assign_operator -> tkPlusEqual
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 952: // assign_operator -> tkMinusEqual
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 953: // assign_operator -> tkMultEqual
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 954: // assign_operator -> tkDivEqual
{ CurrentSemanticValue.op = ValueStack[ValueStack.Depth-1].op; }
        break;
      case 955: // lambda_unpacked_params -> tkBackSlashRoundOpen, 
                //                           lambda_list_of_unpacked_params_or_id, tkComma, 
                //                           lambda_unpacked_params_or_id, tkRoundClose
{
			// ��������� ���� ��������� ������ �� ��������� ���� � function_lambda_definition
			(ValueStack[ValueStack.Depth-4].ob as unpacked_list_of_ident_or_list).Add(ValueStack[ValueStack.Depth-2].ob as ident_or_list);
			CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-4].ob as unpacked_list_of_ident_or_list;
		}
        break;
      case 956: // lambda_unpacked_params_or_id -> lambda_unpacked_params
{
			CurrentSemanticValue.ob = new ident_or_list(ValueStack[ValueStack.Depth-1].ex as unpacked_list_of_ident_or_list);
		}
        break;
      case 957: // lambda_unpacked_params_or_id -> identifier
{
			CurrentSemanticValue.ob = new ident_or_list(ValueStack[ValueStack.Depth-1].id as ident);
		}
        break;
      case 958: // lambda_list_of_unpacked_params_or_id -> lambda_unpacked_params_or_id
{
			CurrentSemanticValue.ob = new unpacked_list_of_ident_or_list();
			(CurrentSemanticValue.ob as unpacked_list_of_ident_or_list).Add(ValueStack[ValueStack.Depth-1].ob as ident_or_list);
			(CurrentSemanticValue.ob as unpacked_list_of_ident_or_list).source_context = LocationStack[LocationStack.Depth-1];
		}
        break;
      case 959: // lambda_list_of_unpacked_params_or_id -> lambda_list_of_unpacked_params_or_id, 
                //                                         tkComma, lambda_unpacked_params_or_id
{
			CurrentSemanticValue.ob = ValueStack[ValueStack.Depth-3].ob;
			(CurrentSemanticValue.ob as unpacked_list_of_ident_or_list).Add(ValueStack[ValueStack.Depth-1].ob as ident_or_list);
			(CurrentSemanticValue.ob as unpacked_list_of_ident_or_list).source_context = LexLocation.MergeAll(LocationStack[LocationStack.Depth-3],LocationStack[LocationStack.Depth-1]);
		}
        break;
      case 960: // expr_l1_or_unpacked -> expr_l1
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 961: // expr_l1_or_unpacked -> lambda_unpacked_params
{ CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; }
        break;
      case 962: // expr_l1_or_unpacked_list -> expr_l1_or_unpacked
{ 
			CurrentSemanticValue.stn = new expression_list(ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan); 
		}
        break;
      case 963: // expr_l1_or_unpacked_list -> expr_l1_or_unpacked_list, tkComma, 
                //                             expr_l1_or_unpacked
{
			CurrentSemanticValue.stn = (ValueStack[ValueStack.Depth-3].stn as expression_list).Add(ValueStack[ValueStack.Depth-1].ex, CurrentLocationSpan); 
		}
        break;
      case 964: // func_decl_lambda -> identifier, tkArrow, lambda_function_body
{
			var idList = new ident_list(ValueStack[ValueStack.Depth-3].id, LocationStack[LocationStack.Depth-3]); 
			var formalPars = new formal_parameters(new typed_parameters(idList, new lambda_inferred_type(new PascalABCCompiler.TreeRealization.lambda_any_type_node(), LocationStack[LocationStack.Depth-3]), parametr_kind.none, null, LocationStack[LocationStack.Depth-3]), LocationStack[LocationStack.Depth-3]);
			//var sl = $3 as statement_list;
			//if (sl.expr_lambda_body || SyntaxVisitors.HasNameVisitor.HasName($3, "Result") != null) // ���� ��� ���� ��������� ��� ���� ���������� Result, �� ��������� ���� 
			    CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), formalPars, new lambda_inferred_type(new PascalABCCompiler.TreeRealization.lambda_any_type_node(), LocationStack[LocationStack.Depth-3]), ValueStack[ValueStack.Depth-1].stn as statement_list, CurrentLocationSpan);
			//else 
			//$$ = new function_lambda_definition(lambdaHelper.CreateLambdaName(), formalPars, null, $3 as statement_list, @$);  
		}
        break;
      case 965: // func_decl_lambda -> tkRoundOpen, tkRoundClose, lambda_type_ref_noproctype, 
                //                     tkArrow, lambda_function_body
{
		    // ����� ���� ������������� �� ���� � ���� ��������� lambda_inferred_type, ���� ������ ��� null!
		    var sl = ValueStack[ValueStack.Depth-1].stn as statement_list;
		    if (sl.expr_lambda_body || SyntaxVisitors.HasNameVisitor.HasName(sl, "result") != null) // �� ���� ��������
				CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), null, ValueStack[ValueStack.Depth-3].td, sl, CurrentLocationSpan);
			else CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), null, null, sl, CurrentLocationSpan);	
		}
        break;
      case 966: // func_decl_lambda -> tkRoundOpen, identifier, tkColon, fptype, tkRoundClose, 
                //                     lambda_type_ref_noproctype, tkArrow, lambda_function_body
{
			var idList = new ident_list(ValueStack[ValueStack.Depth-7].id, LocationStack[LocationStack.Depth-7]); 
            var loc = LexLocation.MergeAll(LocationStack[LocationStack.Depth-7],LocationStack[LocationStack.Depth-6],LocationStack[LocationStack.Depth-5]);
			var formalPars = new formal_parameters(new typed_parameters(idList, ValueStack[ValueStack.Depth-5].td, parametr_kind.none, null, loc), loc);
		    var sl = ValueStack[ValueStack.Depth-1].stn as statement_list;
		    if (sl.expr_lambda_body || SyntaxVisitors.HasNameVisitor.HasName(sl, "result") != null) // �� ���� ��������
				CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), formalPars, ValueStack[ValueStack.Depth-3].td, sl, CurrentLocationSpan);
			else CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), formalPars, null, sl, CurrentLocationSpan);	
		}
        break;
      case 967: // func_decl_lambda -> tkRoundOpen, identifier, tkSemiColon, full_lambda_fp_list, 
                //                     tkRoundClose, lambda_type_ref_noproctype, tkArrow, 
                //                     lambda_function_body
{
			var idList = new ident_list(ValueStack[ValueStack.Depth-7].id, LocationStack[LocationStack.Depth-7]);
			var formalPars = new formal_parameters(new typed_parameters(idList, new lambda_inferred_type(new PascalABCCompiler.TreeRealization.lambda_any_type_node(), null), parametr_kind.none, null, LocationStack[LocationStack.Depth-7]), LexLocation.MergeAll(LocationStack[LocationStack.Depth-7],LocationStack[LocationStack.Depth-6],LocationStack[LocationStack.Depth-5]));
			for (int i = 0; i < (ValueStack[ValueStack.Depth-5].stn as formal_parameters).Count; i++)
				formalPars.Add((ValueStack[ValueStack.Depth-5].stn as formal_parameters).params_list[i]);
		    var sl = ValueStack[ValueStack.Depth-1].stn as statement_list;
		    if (sl.expr_lambda_body || SyntaxVisitors.HasNameVisitor.HasName(sl, "result") != null) // �� ���� ��������
				CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), formalPars, ValueStack[ValueStack.Depth-3].td, sl, CurrentLocationSpan);
			else CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), formalPars, null, sl, CurrentLocationSpan);	
		}
        break;
      case 968: // func_decl_lambda -> tkRoundOpen, identifier, tkColon, fptype, tkSemiColon, 
                //                     full_lambda_fp_list, tkRoundClose, 
                //                     lambda_type_ref_noproctype, tkArrow, lambda_function_body
{
			var idList = new ident_list(ValueStack[ValueStack.Depth-9].id, LocationStack[LocationStack.Depth-9]);
            var loc = LexLocation.MergeAll(LocationStack[LocationStack.Depth-9],LocationStack[LocationStack.Depth-8],LocationStack[LocationStack.Depth-7]);
			var formalPars = new formal_parameters(new typed_parameters(idList, ValueStack[ValueStack.Depth-7].td, parametr_kind.none, null, loc), LexLocation.MergeAll(LocationStack[LocationStack.Depth-9],LocationStack[LocationStack.Depth-8],LocationStack[LocationStack.Depth-7],LocationStack[LocationStack.Depth-6],LocationStack[LocationStack.Depth-5]));
			for (int i = 0; i < (ValueStack[ValueStack.Depth-5].stn as formal_parameters).Count; i++)
				formalPars.Add((ValueStack[ValueStack.Depth-5].stn as formal_parameters).params_list[i]);
		    var sl = ValueStack[ValueStack.Depth-1].stn as statement_list;
		    if (sl.expr_lambda_body || SyntaxVisitors.HasNameVisitor.HasName(sl, "result") != null) // �� ���� ��������
				CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), formalPars, ValueStack[ValueStack.Depth-3].td, sl, CurrentLocationSpan);
			else CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), formalPars, null, sl, CurrentLocationSpan);
		}
        break;
      case 969: // func_decl_lambda -> tkRoundOpen, expr_l1_or_unpacked, tkComma, 
                //                     expr_l1_or_unpacked_list, lambda_type_ref, 
                //                     optional_full_lambda_fp_list, tkRoundClose, rem_lambda
{ 
			var pair = ValueStack[ValueStack.Depth-1].ob as pair_type_stlist;
			
			if (ValueStack[ValueStack.Depth-4].td is lambda_inferred_type)
			{
				// ������� ���� \(x,y)
				// �������� �� ���� expr_list1. ���� ���� �� ���� - ���� ident_or_list �� ����� �� ���� ����� � �����
				// ���������, ��� $6 = null
				// ������������ List<expression> ��� unpacked_params � ���������
				var has_unpacked = false;
				if (ValueStack[ValueStack.Depth-7].ex is unpacked_list_of_ident_or_list)
					has_unpacked = true;
				if (!has_unpacked)
					foreach (var x in (ValueStack[ValueStack.Depth-5].stn as expression_list).expressions)
					{
						if (x is unpacked_list_of_ident_or_list)
						{
							has_unpacked = true;
							break;
						}
					}
				if (has_unpacked) // ��� ����� �����
				{
					if (ValueStack[ValueStack.Depth-3].stn != null)
					{
						parsertools.AddErrorFromResource("SEMICOLON_IN_PARAMS",LocationStack[LocationStack.Depth-3]);
					}
				
					var lst_ex = new List<expression>();
					lst_ex.Add(ValueStack[ValueStack.Depth-7].ex as expression);
					foreach (var x in (ValueStack[ValueStack.Depth-5].stn as expression_list).expressions)
						lst_ex.Add(x);
					
					function_lambda_definition fld = null; //= new function_lambda_definition(lambdaHelper.CreateLambdaName(), null, 
    					//new lambda_inferred_type(new PascalABCCompiler.TreeRealization.lambda_any_type_node(), @2), pair.exprs, @$);

					var sl1 = pair.exprs;
			    	if (sl1.expr_lambda_body || SyntaxVisitors.HasNameVisitor.HasName(sl1, "result") != null) // �� ���� ��������
						fld = new function_lambda_definition(lambdaHelper.CreateLambdaName(), null, pair.tn, pair.exprs, CurrentLocationSpan);
					else fld = new function_lambda_definition(lambdaHelper.CreateLambdaName(), null, null, pair.exprs, CurrentLocationSpan);	

					fld.unpacked_params = lst_ex;
					CurrentSemanticValue.ex = fld;					
					return;
				}
				
				var formal_pars = new formal_parameters();
				var idd = ValueStack[ValueStack.Depth-7].ex as ident;
				if (idd==null)
					parsertools.AddErrorFromResource("ONE_TKIDENTIFIER",LocationStack[LocationStack.Depth-7]);
				var lambda_inf_type = new lambda_inferred_type(new PascalABCCompiler.TreeRealization.lambda_any_type_node(), null);
				var new_typed_pars = new typed_parameters(new ident_list(idd, idd.source_context), lambda_inf_type, parametr_kind.none, null, idd.source_context);
				formal_pars.Add(new_typed_pars);
				foreach (var id in (ValueStack[ValueStack.Depth-5].stn as expression_list).expressions)
				{
					var idd1 = id as ident;
					if (idd1==null)
						parsertools.AddErrorFromResource("ONE_TKIDENTIFIER",id.source_context);
					
					lambda_inf_type = new lambda_inferred_type(new PascalABCCompiler.TreeRealization.lambda_any_type_node(), null);
					new_typed_pars = new typed_parameters(new ident_list(idd1, idd1.source_context), lambda_inf_type, parametr_kind.none, null, idd1.source_context);
					formal_pars.Add(new_typed_pars);
				}
				
				if (ValueStack[ValueStack.Depth-3].stn != null)
					for (int i = 0; i < (ValueStack[ValueStack.Depth-3].stn as formal_parameters).Count; i++)
						formal_pars.Add((ValueStack[ValueStack.Depth-3].stn as formal_parameters).params_list[i]);		
					
				formal_pars.source_context = LexLocation.MergeAll(LocationStack[LocationStack.Depth-7],LocationStack[LocationStack.Depth-6],LocationStack[LocationStack.Depth-5],LocationStack[LocationStack.Depth-4]);
			    
			    var sl = pair.exprs;
			    if (sl.expr_lambda_body || SyntaxVisitors.HasNameVisitor.HasName(sl, "result") != null) // �� ���� ��������
					CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), formal_pars, pair.tn, pair.exprs, CurrentLocationSpan);
				else CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), formal_pars, null, pair.exprs, CurrentLocationSpan);	
			}
			else
			{			
				var loc = LexLocation.MergeAll(LocationStack[LocationStack.Depth-7],LocationStack[LocationStack.Depth-6],LocationStack[LocationStack.Depth-5]);
				var idd = ValueStack[ValueStack.Depth-7].ex as ident;
				if (idd==null)
					parsertools.AddErrorFromResource("ONE_TKIDENTIFIER",LocationStack[LocationStack.Depth-7]);
				
				var idList = new ident_list(idd, loc);
				
				var iddlist = (ValueStack[ValueStack.Depth-5].stn as expression_list).expressions;
				
				for (int j = 0; j < iddlist.Count; j++)
				{
					var idd2 = iddlist[j] as ident;
					if (idd2==null)
						parsertools.AddErrorFromResource("ONE_TKIDENTIFIER",idd2.source_context);
					idList.Add(idd2);
				}	
				var parsType = ValueStack[ValueStack.Depth-4].td;
				var formalPars = new formal_parameters(new typed_parameters(idList, parsType, parametr_kind.none, null, loc), LexLocation.MergeAll(LocationStack[LocationStack.Depth-7],LocationStack[LocationStack.Depth-6],LocationStack[LocationStack.Depth-5],LocationStack[LocationStack.Depth-4],LocationStack[LocationStack.Depth-3]));
				
				if (ValueStack[ValueStack.Depth-3].stn != null)
					for (int i = 0; i < (ValueStack[ValueStack.Depth-3].stn as formal_parameters).Count; i++)
						formalPars.Add((ValueStack[ValueStack.Depth-3].stn as formal_parameters).params_list[i]);

				var sl = pair.exprs;
			    if (sl.expr_lambda_body || SyntaxVisitors.HasNameVisitor.HasName(sl, "result") != null) // �� ���� ��������
					CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), formalPars, pair.tn, pair.exprs, CurrentLocationSpan);
				else CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), formalPars, null, pair.exprs, CurrentLocationSpan);
			}
		}
        break;
      case 970: // func_decl_lambda -> lambda_unpacked_params, rem_lambda
{
    		var pair = ValueStack[ValueStack.Depth-1].ob as pair_type_stlist;
    		// ���� ���������� ��������� - null. �������� �� �������� ���������
    		CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), null, 
    			new lambda_inferred_type(new PascalABCCompiler.TreeRealization.lambda_any_type_node(), LocationStack[LocationStack.Depth-2]), pair.exprs, CurrentLocationSpan);
    		// unpacked_params - ��� ��� ������ ���������. ��� ���������� - ���� ������ ���������. ��������, ������ �������
    		var lst_ex = new List<expression>();
    		lst_ex.Add(ValueStack[ValueStack.Depth-2].ex as unpacked_list_of_ident_or_list);
    		(CurrentSemanticValue.ex as function_lambda_definition).unpacked_params = lst_ex;  
    	}
        break;
      case 971: // func_decl_lambda -> expl_func_decl_lambda
{
			CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].ex; 
		}
        break;
      case 972: // optional_full_lambda_fp_list -> /* empty */
{ CurrentSemanticValue.stn = null; }
        break;
      case 973: // optional_full_lambda_fp_list -> tkSemiColon, full_lambda_fp_list
{
		CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn; 
	}
        break;
      case 974: // rem_lambda -> lambda_type_ref_noproctype, tkArrow, lambda_function_body
{ 
		    CurrentSemanticValue.ob = new pair_type_stlist(ValueStack[ValueStack.Depth-3].td,ValueStack[ValueStack.Depth-1].stn as statement_list);
		}
        break;
      case 975: // expl_func_decl_lambda -> tkFunction, lambda_type_ref_noproctype, tkArrow, 
                //                          lambda_function_body
{
			CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), null, ValueStack[ValueStack.Depth-3].td, ValueStack[ValueStack.Depth-1].stn as statement_list, 1, CurrentLocationSpan);
		}
        break;
      case 976: // expl_func_decl_lambda -> tkFunction, tkRoundOpen, tkRoundClose, 
                //                          lambda_type_ref_noproctype, tkArrow, 
                //                          lambda_function_body
{
			CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), null, ValueStack[ValueStack.Depth-3].td, ValueStack[ValueStack.Depth-1].stn as statement_list, 1, CurrentLocationSpan);
		}
        break;
      case 977: // expl_func_decl_lambda -> tkFunction, tkRoundOpen, full_lambda_fp_list, 
                //                          tkRoundClose, lambda_type_ref_noproctype, tkArrow, 
                //                          lambda_function_body
{
			CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), ValueStack[ValueStack.Depth-5].stn as formal_parameters, ValueStack[ValueStack.Depth-3].td, ValueStack[ValueStack.Depth-1].stn as statement_list, 1, CurrentLocationSpan);
		}
        break;
      case 978: // expl_func_decl_lambda -> tkProcedure, tkArrow, lambda_procedure_body
{
			CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), null, null, ValueStack[ValueStack.Depth-1].stn as statement_list, 2, CurrentLocationSpan);
		}
        break;
      case 979: // expl_func_decl_lambda -> tkProcedure, tkRoundOpen, tkRoundClose, tkArrow, 
                //                          lambda_procedure_body
{
			CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), null, null, ValueStack[ValueStack.Depth-1].stn as statement_list, 2, CurrentLocationSpan);
		}
        break;
      case 980: // expl_func_decl_lambda -> tkProcedure, tkRoundOpen, full_lambda_fp_list, 
                //                          tkRoundClose, tkArrow, lambda_procedure_body
{
			CurrentSemanticValue.ex = new function_lambda_definition(lambdaHelper.CreateLambdaName(), ValueStack[ValueStack.Depth-4].stn as formal_parameters, null, ValueStack[ValueStack.Depth-1].stn as statement_list, 2, CurrentLocationSpan);
		}
        break;
      case 981: // full_lambda_fp_list -> lambda_simple_fp_sect
{
			var typed_pars = ValueStack[ValueStack.Depth-1].stn as typed_parameters;
			if (typed_pars.vars_type is lambda_inferred_type)
			{
				CurrentSemanticValue.stn = new formal_parameters();
				foreach (var id in typed_pars.idents.idents)
				{
					var lambda_inf_type = new lambda_inferred_type(new PascalABCCompiler.TreeRealization.lambda_any_type_node(), null);
					var new_typed_pars = new typed_parameters(new ident_list(id, id.source_context), lambda_inf_type, parametr_kind.none, null, id.source_context);
					(CurrentSemanticValue.stn as formal_parameters).Add(new_typed_pars);
				}
				CurrentSemanticValue.stn.source_context = CurrentLocationSpan;
			}
			else
			{
				CurrentSemanticValue.stn = new formal_parameters(typed_pars, CurrentLocationSpan);
			}
		}
        break;
      case 982: // full_lambda_fp_list -> full_lambda_fp_list, tkSemiColon, lambda_simple_fp_sect
{
			CurrentSemanticValue.stn =(ValueStack[ValueStack.Depth-3].stn as formal_parameters).Add(ValueStack[ValueStack.Depth-1].stn as typed_parameters, CurrentLocationSpan);
		}
        break;
      case 983: // lambda_simple_fp_sect -> ident_list, lambda_type_ref
{
			CurrentSemanticValue.stn = new typed_parameters(ValueStack[ValueStack.Depth-2].stn as ident_list, ValueStack[ValueStack.Depth-1].td, parametr_kind.none, null, CurrentLocationSpan);
		}
        break;
      case 984: // lambda_type_ref -> /* empty */
{
			CurrentSemanticValue.td = new lambda_inferred_type(new PascalABCCompiler.TreeRealization.lambda_any_type_node(), null);
		}
        break;
      case 985: // lambda_type_ref -> tkColon, fptype
{
			CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td;
		}
        break;
      case 986: // lambda_type_ref_noproctype -> /* empty */
{
			CurrentSemanticValue.td = new lambda_inferred_type(new PascalABCCompiler.TreeRealization.lambda_any_type_node(), null);
		}
        break;
      case 987: // lambda_type_ref_noproctype -> tkColon, fptype_noproctype
{
			CurrentSemanticValue.td = ValueStack[ValueStack.Depth-1].td;
		}
        break;
      case 988: // common_lambda_body -> compound_stmt
{
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn;
		}
        break;
      case 989: // common_lambda_body -> if_stmt
{
			CurrentSemanticValue.stn = new statement_list(ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan);
		}
        break;
      case 990: // common_lambda_body -> while_stmt
{
			CurrentSemanticValue.stn = new statement_list(ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan);
		}
        break;
      case 991: // common_lambda_body -> repeat_stmt
{
			CurrentSemanticValue.stn = new statement_list(ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan);
		}
        break;
      case 992: // common_lambda_body -> for_stmt
{
			CurrentSemanticValue.stn = new statement_list(ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan);
		}
        break;
      case 993: // common_lambda_body -> foreach_stmt
{
			CurrentSemanticValue.stn = new statement_list(ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan);
		}
        break;
      case 994: // common_lambda_body -> loop_stmt
{
			CurrentSemanticValue.stn = new statement_list(ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan);
		}
        break;
      case 995: // common_lambda_body -> case_stmt
{
			CurrentSemanticValue.stn = new statement_list(ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan);
		}
        break;
      case 996: // common_lambda_body -> try_stmt
{
			CurrentSemanticValue.stn = new statement_list(ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan);
		}
        break;
      case 997: // common_lambda_body -> lock_stmt
{
			CurrentSemanticValue.stn = new statement_list(ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan);
		}
        break;
      case 998: // common_lambda_body -> raise_stmt
{
			CurrentSemanticValue.stn = new statement_list(ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan);
		}
        break;
      case 999: // common_lambda_body -> yield_stmt
{
			parsertools.AddErrorFromResource("YIELD_STATEMENT_CANNOT_BE_USED_IN_LAMBDA_BODY", CurrentLocationSpan);
		}
        break;
      case 1000: // lambda_function_body -> expr_l1_for_lambda
{
		    var id = SyntaxVisitors.HasNameVisitor.HasName(ValueStack[ValueStack.Depth-1].ex, "Result"); 
            if (id != null)
            {
                 parsertools.AddErrorFromResource("RESULT_IDENT_NOT_EXPECTED_IN_THIS_CONTEXT", id.source_context);
            }
			var sl = new statement_list(new assign("result",ValueStack[ValueStack.Depth-1].ex,CurrentLocationSpan),CurrentLocationSpan); // ���� �������� ��� � assign ��� ������������������� ��� ������ - ����� ��������� ����� Result
			sl.expr_lambda_body = true;
			CurrentSemanticValue.stn = sl;
		}
        break;
      case 1001: // lambda_function_body -> common_lambda_body
{
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn;
		}
        break;
      case 1002: // lambda_procedure_body -> proc_call
{
			CurrentSemanticValue.stn = new statement_list(ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan);
		}
        break;
      case 1003: // lambda_procedure_body -> assignment
{
			CurrentSemanticValue.stn = new statement_list(ValueStack[ValueStack.Depth-1].stn as statement, CurrentLocationSpan);
		}
        break;
      case 1004: // lambda_procedure_body -> common_lambda_body
{
			CurrentSemanticValue.stn = ValueStack[ValueStack.Depth-1].stn;
		}
        break;
    }
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliasses != null && aliasses.ContainsKey(terminal))
        return aliasses[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

}
}
