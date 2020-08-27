// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispatchDetailChanges_Environment
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
  public class DispatchDetailChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DispatchDetailChanges_Environment_ObjectToChange")]
    [Metadata("A single dispatch detail will contain the query definition used to generate a prioritized work list for the user for a particualr type of transaction.  Particular transaction types supported include move-ins, move-outs, and starting of containers against a manufacturing order.", "DispatchDetail", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DispatchDetailChanges_Environment_Parent")]
    [Metadata("Definition of the prioritization rules for the order that material is processed on the shop floor.  A dispatch rule can contain separate details for different types of transactions.", "DispatchRuleChanges", false, false, false, "NamedObjectRef", 1048825, false, false, false, null)]
    protected new Environment _Parent;
    [Metadata("SQL/CDO Query Name", "", false, true, false, "String", 1050378, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispatchDetailChanges_Environment_QueryName")]
    protected Environment _QueryName;
    [Metadata("DispatchType (Enumeration type)", "DispatchTypeEnum", false, false, false, "Integer", 1050377, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispatchDetailChanges_Environment_DispatchType")]
    protected Environment _DispatchType;
    [DataMember(EmitDefaultValue = false, Name = "DispatchDetailChanges_Environment_EnforceDispatch")]
    [Metadata("Generic Boolean", "", false, true, false, "Boolean", 1050379, false, false, false, "0")]
    protected Environment _EnforceDispatch;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DispatchDetailChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

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

    public new Environment Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Parent));
      }
    }

    public Environment QueryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QueryName));
      }
    }

    public Environment DispatchType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DispatchType));
      }
    }

    public Environment EnforceDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnforceDispatch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EnforceDispatch));
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
