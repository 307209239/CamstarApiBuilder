// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollectionGroupDetail_Info
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
  public class DPCollectionGroupDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Info_GroupLayout")]
    protected Info _GroupLayout;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Info_Group")]
    protected Info _Group;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Info_ServiceDetails")]
    protected DPCollectionPointDetail_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Info_LastEnteredOnGMT")]
    protected Info _LastEnteredOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Info_MinimumSamples")]
    protected Info _MinimumSamples;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Info_LastEnteredByRole")]
    protected Info _LastEnteredByRole;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Info_LastEnteredBy")]
    protected Info _LastEnteredBy;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Info_Name")]
    protected Info _Name;

    public Info Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sequence));
      }
    }

    public Info GroupLayout
    {
      [param: In] set
      {
        this.PropertySet(nameof (GroupLayout), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (GroupLayout));
      }
    }

    public Info Group
    {
      [param: In] set
      {
        this.PropertySet(nameof (Group), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Group));
      }
    }

    public DPCollectionPointDetail_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (DPCollectionPointDetail_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Info LastEnteredOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredOnGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastEnteredOnGMT));
      }
    }

    public Info MinimumSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinimumSamples), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MinimumSamples));
      }
    }

    public Info LastEnteredByRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredByRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastEnteredByRole));
      }
    }

    public Info LastEnteredBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredBy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastEnteredBy));
      }
    }

    public Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
