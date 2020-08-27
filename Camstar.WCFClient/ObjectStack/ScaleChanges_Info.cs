// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ScaleChanges_Info
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
  public class ScaleChanges_Info : ResourceChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Info_ChildResources")]
    protected new Info _ChildResources;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Info_ParentResource")]
    protected new Info _ParentResource;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Info_ResourceFamily")]
    protected new Info _ResourceFamily;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Info_WorkingRangeMax")]
    protected Info _WorkingRangeMax;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Info_DecimalPrecision")]
    protected Info _DecimalPrecision;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Info_DecimalScale")]
    protected Info _DecimalScale;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Info_WorkingRangeMin")]
    protected Info _WorkingRangeMin;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Info_Name")]
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

    public new Info ChildResources
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildResources), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildResources));
      }
    }

    public new Info ParentResource
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentResource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentResource));
      }
    }

    public new Info ResourceFamily
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceFamily), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceFamily));
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

    public Info WorkingRangeMax
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkingRangeMax), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkingRangeMax));
      }
    }

    public Info DecimalPrecision
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecimalPrecision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DecimalPrecision));
      }
    }

    public Info DecimalScale
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecimalScale), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DecimalScale));
      }
    }

    public Info WorkingRangeMin
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkingRangeMin), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkingRangeMin));
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
