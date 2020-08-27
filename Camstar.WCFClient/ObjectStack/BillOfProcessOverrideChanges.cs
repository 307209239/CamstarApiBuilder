// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BillOfProcessOverrideChanges
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
  public class BillOfProcessOverrideChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_ESigTxnMap")]
    protected ContainerESigTxnMapChanges[] _ESigTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_ResourceGroup")]
    protected NamedObjectRef _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_ElectronicProcedure")]
    protected RevisionedObjectRef _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_TrainingReqGroup")]
    protected NamedObjectRef _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_TxnMap")]
    protected TxnMapChanges[] _TxnMap;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_LabelTxnMap")]
    protected ContainerLabelMapChanges[] _LabelTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_SpecDescription")]
    protected Primitive<string> _SpecDescription;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_RecipeFile")]
    protected RevisionedObjectRef _RecipeFile;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_DocumentSet")]
    protected NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Setup")]
    protected RevisionedObjectRef _Setup;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is BillOfProcessOverrideChanges && this.CompareArrays((Array) this._ESigTxnMap, (Array) ((BillOfProcessOverrideChanges) obj)._ESigTxnMap) && (object.Equals((object) this._ResourceGroup, (object) ((BillOfProcessOverrideChanges) obj)._ResourceGroup) && object.Equals((object) this._ObjectToChange, (object) ((BillOfProcessOverrideChanges) obj)._ObjectToChange)) && (object.Equals((object) this._ElectronicProcedure, (object) ((BillOfProcessOverrideChanges) obj)._ElectronicProcedure) && object.Equals((object) this._TrainingReqGroup, (object) ((BillOfProcessOverrideChanges) obj)._TrainingReqGroup) && (object.Equals((object) this._Spec, (object) ((BillOfProcessOverrideChanges) obj)._Spec) && this.CompareArrays((Array) this._TxnMap, (Array) ((BillOfProcessOverrideChanges) obj)._TxnMap))) && (this.CompareArrays((Array) this._LabelTxnMap, (Array) ((BillOfProcessOverrideChanges) obj)._LabelTxnMap) && object.Equals((object) this._ListItemToChange, (object) ((BillOfProcessOverrideChanges) obj)._ListItemToChange) && (object.Equals((object) this._SpecDescription, (object) ((BillOfProcessOverrideChanges) obj)._SpecDescription) && object.Equals((object) this._RecipeFile, (object) ((BillOfProcessOverrideChanges) obj)._RecipeFile)) && (object.Equals((object) this._DocumentSet, (object) ((BillOfProcessOverrideChanges) obj)._DocumentSet) && object.Equals((object) this._Setup, (object) ((BillOfProcessOverrideChanges) obj)._Setup) && object.Equals((object) this._Name, (object) ((BillOfProcessOverrideChanges) obj)._Name))) && base.Equals(obj);
    }

    public ContainerESigTxnMapChanges[] ESigTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigTxnMap), (object) value);
      }
      get
      {
        return (ContainerESigTxnMapChanges[]) this.PropertyGet(nameof (ESigTxnMap));
      }
    }

    public NamedObjectRef ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public RevisionedObjectRef ElectronicProcedure
    {
      [param: In] set
      {
        this.PropertySet(nameof (ElectronicProcedure), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ElectronicProcedure));
      }
    }

    public NamedObjectRef TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public RevisionedObjectRef Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Spec));
      }
    }

    public TxnMapChanges[] TxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnMap), (object) value);
      }
      get
      {
        return (TxnMapChanges[]) this.PropertyGet(nameof (TxnMap));
      }
    }

    public ContainerLabelMapChanges[] LabelTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTxnMap), (object) value);
      }
      get
      {
        return (ContainerLabelMapChanges[]) this.PropertyGet(nameof (LabelTxnMap));
      }
    }

    public NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Primitive<string> SpecDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SpecDescription));
      }
    }

    public RevisionedObjectRef RecipeFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeFile), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (RecipeFile));
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
