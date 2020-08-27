// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ScaleChanges_Environment
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
  public class ScaleChanges_Environment : ResourceChanges_Environment
  {
    [Metadata("The user code for unit of material.", "UOM", false, true, false, "NamedObjectRef", 1048629, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Environment_UOM")]
    protected Environment _UOM;
    [Metadata("Scales are resources that provide information about calibration and setup, scale capabilities such as precision, and working range and connection information for device connectivity.", "Scale", false, false, false, "NamedObjectRef", 1052108, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Environment_ChildResources")]
    protected new Environment _ChildResources;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Environment_ParentResource")]
    [Metadata("Scales are resources that provide information about calibration and setup, scale capabilities such as precision, and working range and connection information for device connectivity.", "Scale", false, false, false, "NamedObjectRef", 1052107, false, false, true, null)]
    protected new Environment _ParentResource;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Environment_ResourceFamily")]
    [Metadata("Scale Family is used to differentiate between types of Scales", "ScaleFamily", false, false, false, "NamedObjectRef", 1052144, false, false, true, null)]
    protected new Environment _ResourceFamily;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Environment_ObjectToChange")]
    [Metadata("Scales are resources that provide information about calibration and setup, scale capabilities such as precision, and working range and connection information for device connectivity.", "Scale", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Generic Float", "", false, true, false, "Float", 1051909, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Environment_WorkingRangeMax")]
    protected Environment _WorkingRangeMax;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Environment_DecimalPrecision")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051916, false, false, false, null)]
    protected Environment _DecimalPrecision;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Environment_DecimalScale")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051917, false, false, false, null)]
    protected Environment _DecimalScale;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Environment_WorkingRangeMin")]
    [Metadata("Generic Float", "", false, true, false, "Float", 1051911, false, false, false, null)]
    protected Environment _WorkingRangeMin;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051908, false, false, false, null)]
    protected new Environment _Name;

    public Environment UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM));
      }
    }

    public new Environment ChildResources
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildResources), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildResources));
      }
    }

    public new Environment ParentResource
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentResource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentResource));
      }
    }

    public new Environment ResourceFamily
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceFamily), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceFamily));
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

    public Environment WorkingRangeMax
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkingRangeMax), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkingRangeMax));
      }
    }

    public Environment DecimalPrecision
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecimalPrecision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DecimalPrecision));
      }
    }

    public Environment DecimalScale
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecimalScale), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DecimalScale));
      }
    }

    public Environment WorkingRangeMin
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkingRangeMin), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkingRangeMin));
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
