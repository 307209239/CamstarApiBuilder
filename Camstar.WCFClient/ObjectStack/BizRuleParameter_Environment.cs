// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BizRuleParameter_Environment
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
  public class BizRuleParameter_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameter_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameter_Environment_BusinessRuleHandler")]
    [Metadata("Business Rule Handler", "BusinessRuleHandler", false, false, true, "NamedObjectRef", 1051887, false, false, false, null)]
    protected Environment _BusinessRuleHandler;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameter_Environment_ValueExpression")]
    [Metadata("InSite Unified Expression", "", false, false, true, "String", 1049630, false, false, false, null)]
    protected Environment _ValueExpression;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameter_Environment_ParamSpec")]
    [Metadata("Business Rule Handler Parameter", "BizRuleHandlerParameter", false, false, true, "NamedSubentityRef", 1051197, false, false, false, null)]
    protected Environment _ParamSpec;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameter_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment BusinessRuleHandler
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRuleHandler), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BusinessRuleHandler));
      }
    }

    public Environment ValueExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValueExpression), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ValueExpression));
      }
    }

    public Environment ParamSpec
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParamSpec), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParamSpec));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
