// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaintenanceReqChanges
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
  public class MaintenanceReqChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_DataCollectionDef")]
    protected RevisionedObjectRef _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_MaintenanceReason")]
    protected NamedObjectRef _MaintenanceReason;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_PendingEmailTarget")]
    protected NamedObjectRef[] _PendingEmailTarget;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_DueEmailTarget")]
    protected NamedObjectRef[] _DueEmailTarget;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_PastDueEmailTarget")]
    protected NamedObjectRef[] _PastDueEmailTarget;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_ESigRequirement")]
    protected NamedObjectRef _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_DueEmailText")]
    protected Primitive<string> _DueEmailText;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_DocumentSet")]
    protected NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_PendingEmailText")]
    protected Primitive<string> _PendingEmailText;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_PastDueEmailText")]
    protected Primitive<string> _PastDueEmailText;

    public override bool Equals(object obj)
    {
      return obj is MaintenanceReqChanges && object.Equals((object) this._DataCollectionDef, (object) ((MaintenanceReqChanges) obj)._DataCollectionDef) && (object.Equals((object) this._ObjectToChange, (object) ((MaintenanceReqChanges) obj)._ObjectToChange) && object.Equals((object) this._Base, (object) ((MaintenanceReqChanges) obj)._Base)) && (object.Equals((object) this._MaintenanceReason, (object) ((MaintenanceReqChanges) obj)._MaintenanceReason) && this.CompareArrays((Array) this._PendingEmailTarget, (Array) ((MaintenanceReqChanges) obj)._PendingEmailTarget) && (this.CompareArrays((Array) this._DueEmailTarget, (Array) ((MaintenanceReqChanges) obj)._DueEmailTarget) && this.CompareArrays((Array) this._PastDueEmailTarget, (Array) ((MaintenanceReqChanges) obj)._PastDueEmailTarget))) && (object.Equals((object) this._ESigRequirement, (object) ((MaintenanceReqChanges) obj)._ESigRequirement) && object.Equals((object) this._DueEmailText, (object) ((MaintenanceReqChanges) obj)._DueEmailText) && (object.Equals((object) this._DocumentSet, (object) ((MaintenanceReqChanges) obj)._DocumentSet) && object.Equals((object) this._Name, (object) ((MaintenanceReqChanges) obj)._Name)) && (object.Equals((object) this._PendingEmailText, (object) ((MaintenanceReqChanges) obj)._PendingEmailText) && object.Equals((object) this._PastDueEmailText, (object) ((MaintenanceReqChanges) obj)._PastDueEmailText))) && base.Equals(obj);
    }

    public RevisionedObjectRef DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (DataCollectionDef));
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

    public NamedObjectRef MaintenanceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MaintenanceReason));
      }
    }

    public NamedObjectRef[] PendingEmailTarget
    {
      [param: In] set
      {
        this.PropertySet(nameof (PendingEmailTarget), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (PendingEmailTarget));
      }
    }

    public NamedObjectRef[] DueEmailTarget
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueEmailTarget), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (DueEmailTarget));
      }
    }

    public NamedObjectRef[] PastDueEmailTarget
    {
      [param: In] set
      {
        this.PropertySet(nameof (PastDueEmailTarget), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (PastDueEmailTarget));
      }
    }

    public NamedObjectRef ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public Primitive<string> DueEmailText
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueEmailText), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DueEmailText));
      }
    }

    public NamedObjectRef DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DocumentSet));
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

    public Primitive<string> PendingEmailText
    {
      [param: In] set
      {
        this.PropertySet(nameof (PendingEmailText), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PendingEmailText));
      }
    }

    public Primitive<string> PastDueEmailText
    {
      [param: In] set
      {
        this.PropertySet(nameof (PastDueEmailText), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PastDueEmailText));
      }
    }
  }
}
