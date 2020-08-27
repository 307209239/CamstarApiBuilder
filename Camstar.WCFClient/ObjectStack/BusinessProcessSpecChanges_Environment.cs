// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessProcessSpecChanges_Environment
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
  public class BusinessProcessSpecChanges_Environment : RevisionedObjectChanges_Environment
  {
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components.", "BusinessProcessSpecBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecChanges_Environment_Base")]
    protected new Environment _Base;
    [Metadata("An enumeration that contains the event during which a business rule should fire.", "BPSpecBizRuleTxnMapChanges", false, false, false, "BPSpecBizRuleTxnMapChanges", 16779372, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecChanges_Environment_BPSpecBizRuleTxnMap")]
    protected BPSpecBizRuleTxnMapChanges_Environment _BPSpecBizRuleTxnMap;
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components.", "BusinessProcessSpec", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1053249, false, false, false, null)]
    protected new Environment _Name;

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
      }
    }

    public BPSpecBizRuleTxnMapChanges_Environment BPSpecBizRuleTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (BPSpecBizRuleTxnMap), (object) value);
      }
      get
      {
        return (BPSpecBizRuleTxnMapChanges_Environment) this.PropertyGet(nameof (BPSpecBizRuleTxnMap));
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
