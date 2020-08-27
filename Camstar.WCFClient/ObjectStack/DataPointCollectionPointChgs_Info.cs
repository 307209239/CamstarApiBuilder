// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollectionPointChgs_Info
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
  public class DataPointCollectionPointChgs_Info : DataPointChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Info_DataType")]
    protected new Info _DataType;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Info_OuterLowerLimit")]
    protected Info _OuterLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Info_InnerLowerLimit")]
    protected Info _InnerLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Info_OuterUpperLimit")]
    protected Info _OuterUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Info_InnerUpperLimit")]
    protected Info _InnerUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Info_MinimumSamples")]
    protected Info _MinimumSamples;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Info_Name")]
    protected new Info _Name;

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

    public new Info DataType
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

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
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

    public new Info Name
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
