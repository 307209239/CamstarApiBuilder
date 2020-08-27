// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BonusReasonMaint_Environment
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
  public class BonusReasonMaint_Environment : UserCodeMaint_Environment
  {
    [Metadata("Changes CDO for BonusReason.", "BonusReasonChanges", false, false, false, "BonusReasonChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BonusReasonMaint_Environment_ObjectChanges")]
    protected BonusReasonChanges_Environment _ObjectChanges;
    [Metadata("The user code for bonus reason.", "BonusReason", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BonusReasonMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("The user code for bonus reason.", "BonusReason", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BonusReasonMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;

    public BonusReasonChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (BonusReasonChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
