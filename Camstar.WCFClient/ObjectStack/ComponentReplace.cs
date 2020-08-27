// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentReplace
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
  public class ComponentReplace : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplace_IssueActualHistory")]
    protected SubentityRef _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplace_ServiceDetails")]
    protected ComponentReplaceDetail[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplace_BillControl")]
    protected Primitive<bool> _BillControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplace_AllowZeroQtys")]
    protected Primitive<bool> _AllowZeroQtys;

    public override bool Equals(object obj)
    {
      return obj is ComponentReplace && object.Equals((object) this._IssueActualHistory, (object) ((ComponentReplace) obj)._IssueActualHistory) && (this.CompareArrays((Array) this._ServiceDetails, (Array) ((ComponentReplace) obj)._ServiceDetails) && object.Equals((object) this._BillControl, (object) ((ComponentReplace) obj)._BillControl)) && object.Equals((object) this._AllowZeroQtys, (object) ((ComponentReplace) obj)._AllowZeroQtys) && base.Equals(obj);
    }

    public SubentityRef IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (IssueActualHistory));
      }
    }

    public ComponentReplaceDetail[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ComponentReplaceDetail[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Primitive<bool> BillControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillControl), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (BillControl));
      }
    }

    public Primitive<bool> AllowZeroQtys
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowZeroQtys), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowZeroQtys));
      }
    }
  }
}
