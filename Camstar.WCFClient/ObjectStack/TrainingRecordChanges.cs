// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrainingRecordChanges
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
  public class TrainingRecordChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordChanges_ESigRequirement")]
    protected NamedObjectRef _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordChanges_TrainingRequirement")]
    protected RevisionedObjectRef _TrainingRequirement;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordChanges_ChangeHistory")]
    protected ChangeHistoryChanges _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordChanges_Status")]
    protected NamedObjectRef _Status;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordChanges_ExpirationDate")]
    protected Primitive<DateTime> _ExpirationDate;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordChanges_Parent")]
    protected NamedObjectRef _Parent;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is TrainingRecordChanges && object.Equals((object) this._ESigRequirement, (object) ((TrainingRecordChanges) obj)._ESigRequirement) && (object.Equals((object) this._ObjectToChange, (object) ((TrainingRecordChanges) obj)._ObjectToChange) && object.Equals((object) this._TrainingRequirement, (object) ((TrainingRecordChanges) obj)._TrainingRequirement)) && (object.Equals((object) this._ChangeHistory, (object) ((TrainingRecordChanges) obj)._ChangeHistory) && object.Equals((object) this._Status, (object) ((TrainingRecordChanges) obj)._Status) && (object.Equals((object) this._ListItemToChange, (object) ((TrainingRecordChanges) obj)._ListItemToChange) && object.Equals((object) this._ExpirationDate, (object) ((TrainingRecordChanges) obj)._ExpirationDate))) && (object.Equals((object) this._Parent, (object) ((TrainingRecordChanges) obj)._Parent) && object.Equals((object) this._IsFrozen, (object) ((TrainingRecordChanges) obj)._IsFrozen)) && base.Equals(obj);
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

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public RevisionedObjectRef TrainingRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingRequirement), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (TrainingRequirement));
      }
    }

    public ChangeHistoryChanges ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public NamedObjectRef Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Status));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Primitive<DateTime> ExpirationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ExpirationDate));
      }
    }

    public NamedObjectRef Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Parent));
      }
    }

    public Primitive<bool> IsFrozen
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
  }
}
