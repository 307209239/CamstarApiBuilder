// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TextVariableChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class TextVariableChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("String to be evaluated to produce a value at run-time.", "", false, false, false, "String", 1049630, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TextVariableChanges_Environment_VariableExpression")]
    protected Environment _VariableExpression;
    [DataMember(EmitDefaultValue = false, Name = "TextVariableChanges_Environment_ObjectToChange")]
    [Metadata("Text variables describe how to derive a value at run-time that is to be incorporated into a message string. They are used by various objects (such as WIP Messages, History Inquiries, etc.) to incorporate variables in strings.  Each Text Variable defined must include a name and an expression. \r\n\r\nThe name is the value embedded in the static string prefixed by a character that identifies it as a Text Variable. For example, a Text Variable with the name TEMP would be included in message text as \"Set temperature to #TEMP\". \r\n\r\nThe expression is a string to be evaluated at run-time to produce the value that replaces the identifier within the run-time version of the string.  The expression is defined using the standard InSite unified expression syntax. Since an expression can drill into fields in a service, many times an expression might only be valid for a particular type of service.", "TextVariable", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("String to be evaluated to produce a value at run-time.", "", false, false, false, "String", 1048902, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TextVariableChanges_Environment_UnresolvedValue")]
    protected Environment _UnresolvedValue;
    [Metadata("Defines the type of Variable. For example:\r\n\r\n1 = General (can be used in any text)\r\n2 = WIP Message\r\n3 = Alarm Message\r\n4 = Instruction Text", "TextVariableTypeEnum", false, false, false, "Integer", 1049631, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TextVariableChanges_Environment_VariableUsage")]
    protected Environment _VariableUsage;
    [DataMember(EmitDefaultValue = false, Name = "TextVariableChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050094, false, false, false, null)]
    protected new Environment _Name;

    public Environment VariableExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (VariableExpression), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (VariableExpression));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment UnresolvedValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnresolvedValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UnresolvedValue));
      }
    }

    public Environment VariableUsage
    {
      [param: In] set
      {
        this.PropertySet(nameof (VariableUsage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (VariableUsage));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
