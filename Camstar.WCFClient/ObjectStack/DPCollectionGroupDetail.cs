// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollectionGroupDetail
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
  public class DPCollectionGroupDetail : Camstar.WCF.ObjectStack.ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_GroupLayout")]
    protected Enumeration<DPCollectionGroupLayoutEnum, int> _GroupLayout;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Group")]
    protected NamedSubentityRef _Group;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_ServiceDetails")]
    protected DPCollectionPointDetail[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_LastEnteredOnGMT")]
    protected Primitive<DateTime> _LastEnteredOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_MinimumSamples")]
    protected Primitive<int> _MinimumSamples;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_LastEnteredByRole")]
    protected Primitive<string> _LastEnteredByRole;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_LastEnteredBy")]
    protected Primitive<string> _LastEnteredBy;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Name")]
    protected Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is DPCollectionGroupDetail && object.Equals((object) this._Sequence, (object) ((DPCollectionGroupDetail) obj)._Sequence) && (object.Equals((object) this._GroupLayout, (object) ((DPCollectionGroupDetail) obj)._GroupLayout) && object.Equals((object) this._Group, (object) ((DPCollectionGroupDetail) obj)._Group)) && (this.CompareArrays((Array) this._ServiceDetails, (Array) ((DPCollectionGroupDetail) obj)._ServiceDetails) && object.Equals((object) this._LastEnteredOnGMT, (object) ((DPCollectionGroupDetail) obj)._LastEnteredOnGMT) && (object.Equals((object) this._MinimumSamples, (object) ((DPCollectionGroupDetail) obj)._MinimumSamples) && object.Equals((object) this._LastEnteredByRole, (object) ((DPCollectionGroupDetail) obj)._LastEnteredByRole))) && (object.Equals((object) this._LastEnteredBy, (object) ((DPCollectionGroupDetail) obj)._LastEnteredBy) && object.Equals((object) this._Name, (object) ((DPCollectionGroupDetail) obj)._Name)) && base.Equals(obj);
    }

    public Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
      }
    }

    public Enumeration<DPCollectionGroupLayoutEnum, int> GroupLayout
    {
      [param: In] set
      {
        this.PropertySet(nameof (GroupLayout), (object) value);
      }
      get
      {
        return (Enumeration<DPCollectionGroupLayoutEnum, int>) this.PropertyGet(nameof (GroupLayout));
      }
    }

    public NamedSubentityRef Group
    {
      [param: In] set
      {
        this.PropertySet(nameof (Group), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Group));
      }
    }

    public DPCollectionPointDetail[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (DPCollectionPointDetail[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Primitive<DateTime> LastEnteredOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredOnGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastEnteredOnGMT));
      }
    }

    public Primitive<int> MinimumSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinimumSamples), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (MinimumSamples));
      }
    }

    public Primitive<string> LastEnteredByRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredByRole), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LastEnteredByRole));
      }
    }

    public Primitive<string> LastEnteredBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredBy), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LastEnteredBy));
      }
    }

    public Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
