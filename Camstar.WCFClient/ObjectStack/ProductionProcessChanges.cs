// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProductionProcessChanges
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
  public class ProductionProcessChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_ExecutionMode")]
    protected Enumeration<ExecutionModeEnum, int> _ExecutionMode;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_DisplayMode")]
    protected Enumeration<DisplayModeEnum, int> _DisplayMode;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_EProcedureDetails")]
    protected ProductionProcessDetailChanges[] _EProcedureDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_IsRevOfRcd")]
    protected new Primitive<bool> _IsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ProductionProcessChanges && object.Equals((object) this._ExecutionMode, (object) ((ProductionProcessChanges) obj)._ExecutionMode) && (object.Equals((object) this._DisplayMode, (object) ((ProductionProcessChanges) obj)._DisplayMode) && this.CompareArrays((Array) this._EProcedureDetails, (Array) ((ProductionProcessChanges) obj)._EProcedureDetails)) && (object.Equals((object) this._ObjectToChange, (object) ((ProductionProcessChanges) obj)._ObjectToChange) && object.Equals((object) this._Base, (object) ((ProductionProcessChanges) obj)._Base) && (object.Equals((object) this._IsRevOfRcd, (object) ((ProductionProcessChanges) obj)._IsRevOfRcd) && object.Equals((object) this._Name, (object) ((ProductionProcessChanges) obj)._Name))) && base.Equals(obj);
    }

    public Enumeration<ExecutionModeEnum, int> ExecutionMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionMode), (object) value);
      }
      get
      {
        return (Enumeration<ExecutionModeEnum, int>) this.PropertyGet(nameof (ExecutionMode));
      }
    }

    public Enumeration<DisplayModeEnum, int> DisplayMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayMode), (object) value);
      }
      get
      {
        return (Enumeration<DisplayModeEnum, int>) this.PropertyGet(nameof (DisplayMode));
      }
    }

    public ProductionProcessDetailChanges[] EProcedureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EProcedureDetails), (object) value);
      }
      get
      {
        return (ProductionProcessDetailChanges[]) this.PropertyGet(nameof (EProcedureDetails));
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
  }
}
