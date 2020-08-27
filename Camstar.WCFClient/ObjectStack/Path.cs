// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Path
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (MovePath))]
  [KnownType(typeof (ReworkPath))]
  [Serializable]
  public class Path : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "Path_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "Path_OnDefaultRoute")]
    protected Primitive<bool> _OnDefaultRoute;
    [DataMember(EmitDefaultValue = false, Name = "Path_IsDefaultPath")]
    protected Primitive<bool> _IsDefaultPath;
    [DataMember(EmitDefaultValue = false, Name = "Path_Notes")]
    protected Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "Path_ReturnToStep")]
    protected NamedSubentityRef _ReturnToStep;
    [DataMember(EmitDefaultValue = false, Name = "Path_FromStep")]
    protected NamedSubentityRef _FromStep;
    [DataMember(EmitDefaultValue = false, Name = "Path_ToStep")]
    protected NamedSubentityRef _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "Path_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "Path_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "Path_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "Path_TxnDetails")]
    protected TxnDetails _TxnDetails;

    public override bool Equals(object obj)
    {
      return obj is Path && object.Equals((object) this._ExportImportKey, (object) ((Path) obj)._ExportImportKey) && (object.Equals((object) this._OnDefaultRoute, (object) ((Path) obj)._OnDefaultRoute) && object.Equals((object) this._IsDefaultPath, (object) ((Path) obj)._IsDefaultPath)) && (object.Equals((object) this._Notes, (object) ((Path) obj)._Notes) && object.Equals((object) this._ReturnToStep, (object) ((Path) obj)._ReturnToStep) && (object.Equals((object) this._FromStep, (object) ((Path) obj)._FromStep) && object.Equals((object) this._ToStep, (object) ((Path) obj)._ToStep))) && (object.Equals((object) this._IsFrozen, (object) ((Path) obj)._IsFrozen) && object.Equals((object) this._Name, (object) ((Path) obj)._Name) && (object.Equals((object) this._Description, (object) ((Path) obj)._Description) && object.Equals((object) this._TxnDetails, (object) ((Path) obj)._TxnDetails))) && base.Equals(obj);
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

    public Primitive<bool> OnDefaultRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnDefaultRoute), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OnDefaultRoute));
      }
    }

    public Primitive<bool> IsDefaultPath
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDefaultPath), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsDefaultPath));
      }
    }

    public Primitive<string> Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Notes));
      }
    }

    public NamedSubentityRef ReturnToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReturnToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ReturnToStep));
      }
    }

    public NamedSubentityRef FromStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (FromStep));
      }
    }

    public NamedSubentityRef ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ToStep));
      }
    }

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
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

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public TxnDetails TxnDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDetails), (object) value);
      }
      get
      {
        return (TxnDetails) this.PropertyGet(nameof (TxnDetails));
      }
    }
  }
}
