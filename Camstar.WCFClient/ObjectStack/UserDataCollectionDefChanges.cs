// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserDataCollectionDefChanges
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
  public class UserDataCollectionDefChanges : DataCollectionDefChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_DataPoints")]
    protected DataPointChanges[] _DataPoints;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_DataPointLayout")]
    protected Enumeration<DataPointLayoutEnum, int> _DataPointLayout;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_ParametricDataDefType")]
    protected new Primitive<int> _ParametricDataDefType;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_DisplayLimits")]
    protected Primitive<bool> _DisplayLimits;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_ParametricDataDef")]
    protected new Primitive<string> _ParametricDataDef;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_IsRevOfRcd")]
    protected new Primitive<bool> _IsRevOfRcd;

    public override bool Equals(object obj)
    {
      return obj is UserDataCollectionDefChanges && this.CompareArrays((Array) this._DataPoints, (Array) ((UserDataCollectionDefChanges) obj)._DataPoints) && (object.Equals((object) this._ObjectToChange, (object) ((UserDataCollectionDefChanges) obj)._ObjectToChange) && object.Equals((object) this._Base, (object) ((UserDataCollectionDefChanges) obj)._Base)) && (object.Equals((object) this._DataPointLayout, (object) ((UserDataCollectionDefChanges) obj)._DataPointLayout) && object.Equals((object) this._ParametricDataDefType, (object) ((UserDataCollectionDefChanges) obj)._ParametricDataDefType) && (object.Equals((object) this._DisplayLimits, (object) ((UserDataCollectionDefChanges) obj)._DisplayLimits) && object.Equals((object) this._Name, (object) ((UserDataCollectionDefChanges) obj)._Name))) && (object.Equals((object) this._ParametricDataDef, (object) ((UserDataCollectionDefChanges) obj)._ParametricDataDef) && object.Equals((object) this._IsRevOfRcd, (object) ((UserDataCollectionDefChanges) obj)._IsRevOfRcd)) && base.Equals(obj);
    }

    public DataPointChanges[] DataPoints
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPoints), (object) value);
      }
      get
      {
        return (DataPointChanges[]) this.PropertyGet(nameof (DataPoints));
      }
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }

    public Enumeration<DataPointLayoutEnum, int> DataPointLayout
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointLayout), (object) value);
      }
      get
      {
        return (Enumeration<DataPointLayoutEnum, int>) this.PropertyGet(nameof (DataPointLayout));
      }
    }

    public new Primitive<int> ParametricDataDefType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDefType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ParametricDataDefType));
      }
    }

    public Primitive<bool> DisplayLimits
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayLimits), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DisplayLimits));
      }
    }

    public new Primitive<string> Name
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

    public new Primitive<string> ParametricDataDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDef), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParametricDataDef));
      }
    }

    public new Primitive<bool> IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRevOfRcd));
      }
    }
  }
}
