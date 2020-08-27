// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceThruputHistory
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
  public class ResourceThruputHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_Run")]
    protected Primitive<string> _Run;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_MfgOrder")]
    protected NamedObjectRef _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_Setup")]
    protected RevisionedObjectRef _Setup;

    public override bool Equals(object obj)
    {
      return obj is ResourceThruputHistory && this.CompareArrays((Array) this._HistoryDetails, (Array) ((ResourceThruputHistory) obj)._HistoryDetails) && (object.Equals((object) this._ExportImportKey, (object) ((ResourceThruputHistory) obj)._ExportImportKey) && object.Equals((object) this._Qty2, (object) ((ResourceThruputHistory) obj)._Qty2)) && (object.Equals((object) this._UOM, (object) ((ResourceThruputHistory) obj)._UOM) && object.Equals((object) this._UOM2, (object) ((ResourceThruputHistory) obj)._UOM2) && (object.Equals((object) this._HistoryId, (object) ((ResourceThruputHistory) obj)._HistoryId) && object.Equals((object) this._Resource, (object) ((ResourceThruputHistory) obj)._Resource))) && (object.Equals((object) this._Run, (object) ((ResourceThruputHistory) obj)._Run) && object.Equals((object) this._Product, (object) ((ResourceThruputHistory) obj)._Product) && (object.Equals((object) this._Qty, (object) ((ResourceThruputHistory) obj)._Qty) && object.Equals((object) this._MfgOrder, (object) ((ResourceThruputHistory) obj)._MfgOrder)) && object.Equals((object) this._Setup, (object) ((ResourceThruputHistory) obj)._Setup)) && base.Equals(obj);
    }

    public new ServiceHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Primitive<double> Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2));
      }
    }

    public NamedObjectRef UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM));
      }
    }

    public NamedObjectRef UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM2));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }

    public Primitive<string> Run
    {
      [param: In] set
      {
        this.PropertySet(nameof (Run), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Run));
      }
    }

    public RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
      }
    }

    public Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }

    public NamedObjectRef MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MfgOrder));
      }
    }

    public RevisionedObjectRef Setup
    {
      [param: In] set
      {
        this.PropertySet(nameof (Setup), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Setup));
      }
    }
  }
}
