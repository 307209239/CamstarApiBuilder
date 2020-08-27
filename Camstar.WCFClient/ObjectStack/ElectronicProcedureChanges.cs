// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ElectronicProcedureChanges
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
  public class ElectronicProcedureChanges : ProductionProcessChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ElectronicProcedureChanges_EProcedureDetails")]
    protected EProcedureDetailChanges[] _EProcedureDetails;
    [DataMember(EmitDefaultValue = false, Name = "ElectronicProcedureChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "ElectronicProcedureChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ElectronicProcedureChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ElectronicProcedureChanges_IsRevOfRcd")]
    protected new Primitive<bool> _IsRevOfRcd;

    public override bool Equals(object obj)
    {
      return obj is ElectronicProcedureChanges && this.CompareArrays((Array) this._EProcedureDetails, (Array) ((ElectronicProcedureChanges) obj)._EProcedureDetails) && (object.Equals((object) this._Base, (object) ((ElectronicProcedureChanges) obj)._Base) && object.Equals((object) this._ObjectToChange, (object) ((ElectronicProcedureChanges) obj)._ObjectToChange)) && (object.Equals((object) this._Name, (object) ((ElectronicProcedureChanges) obj)._Name) && object.Equals((object) this._IsRevOfRcd, (object) ((ElectronicProcedureChanges) obj)._IsRevOfRcd)) && base.Equals(obj);
    }

    public EProcedureDetailChanges[] EProcedureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EProcedureDetails), (object) value);
      }
      get
      {
        return (EProcedureDetailChanges[]) this.PropertyGet(nameof (EProcedureDetails));
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
