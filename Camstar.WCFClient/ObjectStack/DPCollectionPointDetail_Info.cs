// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollectionPointDetail_Info
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
  public class DPCollectionPointDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Info_Point")]
    protected Info _Point;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Info_Samples")]
    protected DPCollectionSampleDetail_Info _Samples;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Info_DataType")]
    protected Info _DataType;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Info_InnerUpperLimit")]
    protected Info _InnerUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Info_MinimumSamples")]
    protected Info _MinimumSamples;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Info_OuterLowerLimit")]
    protected Info _OuterLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Info_InnerLowerLimit")]
    protected Info _InnerLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Info_OuterUpperLimit")]
    protected Info _OuterUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Info_Name")]
    protected Info _Name;

    public Info UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM));
      }
    }

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

    public Info Point
    {
      [param: In] set
      {
        this.PropertySet(nameof (Point), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Point));
      }
    }

    public DPCollectionSampleDetail_Info Samples
    {
      [param: In] set
      {
        this.PropertySet(nameof (Samples), (object) value);
      }
      get
      {
        return (DPCollectionSampleDetail_Info) this.PropertyGet(nameof (Samples));
      }
    }

    public Info DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataType));
      }
    }

    public Info InnerUpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (InnerUpperLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InnerUpperLimit));
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

    public Info OuterLowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (OuterLowerLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OuterLowerLimit));
      }
    }

    public Info InnerLowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (InnerLowerLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InnerLowerLimit));
      }
    }

    public Info OuterUpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (OuterUpperLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OuterUpperLimit));
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
