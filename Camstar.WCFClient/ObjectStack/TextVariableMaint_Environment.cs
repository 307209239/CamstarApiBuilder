// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TextVariableMaint_Environment
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
  public class TextVariableMaint_Environment : NamedDataObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "TextVariableMaint_Environment_ObjectChanges")]
    [Metadata("Changes CDO used as a working area during TextVariable maintenance", "TextVariableChanges", false, false, false, "TextVariableChanges", 1048873, true, false, false, null)]
    protected TextVariableChanges_Environment _ObjectChanges;
    [Metadata("Text variables describe how to derive a value at run-time that is to be incorporated into a message string. They are used by various objects (such as WIP Messages, History Inquiries, etc.) to incorporate variables in strings.  Each Text Variable defined must include a name and an expression. \r\n\r\nThe name is the value embedded in the static string prefixed by a character that identifies it as a Text Variable. For example, a Text Variable with the name TEMP would be included in message text as \"Set temperature to #TEMP\". \r\n\r\nThe expression is a string to be evaluated at run-time to produce the value that replaces the identifier within the run-time version of the string.  The expression is defined using the standard InSite unified expression syntax. Since an expression can drill into fields in a service, many times an expression might only be valid for a particular type of service.", "TextVariable", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TextVariableMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Text variables describe how to derive a value at run-time that is to be incorporated into a message string. They are used by various objects (such as WIP Messages, History Inquiries, etc.) to incorporate variables in strings.  Each Text Variable defined must include a name and an expression. \r\n\r\nThe name is the value embedded in the static string prefixed by a character that identifies it as a Text Variable. For example, a Text Variable with the name TEMP would be included in message text as \"Set temperature to #TEMP\". \r\n\r\nThe expression is a string to be evaluated at run-time to produce the value that replaces the identifier within the run-time version of the string.  The expression is defined using the standard InSite unified expression syntax. Since an expression can drill into fields in a service, many times an expression might only be valid for a particular type of service.", "TextVariable", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TextVariableMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;

    public TextVariableChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (TextVariableChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }
  }
}
