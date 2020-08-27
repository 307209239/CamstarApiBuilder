// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataCollectionDefChanges_Info
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
  public class DataCollectionDefChanges_Info : RevisionedObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Info_ParametricDataControl")]
    protected Info _ParametricDataControl;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Info_SPCChartDefGroup")]
    protected Info _SPCChartDefGroup;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Info_SPCChartDefEntries")]
    protected Info _SPCChartDefEntries;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Info_SPCChartDefGroupProxy")]
    protected SPCChartDefGroup_Info _SPCChartDefGroupProxy;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Info_WebPart")]
    protected Info _WebPart;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Info_ParametricDataDefType")]
    protected Info _ParametricDataDefType;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Info_IsRevOfRcd")]
    protected new Info _IsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Info_ParametricDataDef")]
    protected Info _ParametricDataDef;

    public Info ParametricDataControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataControl), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParametricDataControl));
      }
    }

    public Info SPCChartDefGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDefGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SPCChartDefGroup));
      }
    }

    public Info SPCChartDefEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDefEntries), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SPCChartDefEntries));
      }
    }

    public SPCChartDefGroup_Info SPCChartDefGroupProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDefGroupProxy), (object) value);
      }
      get
      {
        return (SPCChartDefGroup_Info) this.PropertyGet(nameof (SPCChartDefGroupProxy));
      }
    }

    public Info WebPart
    {
      [param: In] set
      {
        this.PropertySet(nameof (WebPart), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WebPart));
      }
    }

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
      }
    }

    public Info ParametricDataDefType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDefType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParametricDataDefType));
      }
    }

    public new Info IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRevOfRcd));
      }
    }

    public new Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
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

    public Info ParametricDataDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParametricDataDef));
      }
    }
  }
}
