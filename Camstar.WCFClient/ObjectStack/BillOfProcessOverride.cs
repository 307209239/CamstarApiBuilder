// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BillOfProcessOverride
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
  public class BillOfProcessOverride : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_ESigTxnMap")]
    protected ContainerESigTxnMap[] _ESigTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_TrainingReqGroup")]
    protected NamedObjectRef _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_ElectronicProcedure")]
    protected RevisionedObjectRef _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_ResourceGroup")]
    protected NamedObjectRef _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_LabelTxnMap")]
    protected ContainerLabelMap[] _LabelTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_TxnMap")]
    protected Camstar.WCF.ObjectStack.TxnMap[] _TxnMap;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_RecipeFile")]
    protected RevisionedObjectRef _RecipeFile;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_DocumentSet")]
    protected NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Setup")]
    protected RevisionedObjectRef _Setup;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is BillOfProcessOverride && object.Equals((object) this._Spec, (object) ((BillOfProcessOverride) obj)._Spec) && (this.CompareArrays((Array) this._ESigTxnMap, (Array) ((BillOfProcessOverride) obj)._ESigTxnMap) && object.Equals((object) this._TrainingReqGroup, (object) ((BillOfProcessOverride) obj)._TrainingReqGroup)) && (object.Equals((object) this._ElectronicProcedure, (object) ((BillOfProcessOverride) obj)._ElectronicProcedure) && object.Equals((object) this._ExportImportKey, (object) ((BillOfProcessOverride) obj)._ExportImportKey) && (object.Equals((object) this._ResourceGroup, (object) ((BillOfProcessOverride) obj)._ResourceGroup) && this.CompareArrays((Array) this._LabelTxnMap, (Array) ((BillOfProcessOverride) obj)._LabelTxnMap))) && (this.CompareArrays((Array) this._TxnMap, (Array) ((BillOfProcessOverride) obj)._TxnMap) && object.Equals((object) this._RecipeFile, (object) ((BillOfProcessOverride) obj)._RecipeFile) && (object.Equals((object) this._DocumentSet, (object) ((BillOfProcessOverride) obj)._DocumentSet) && object.Equals((object) this._Name, (object) ((BillOfProcessOverride) obj)._Name)) && (object.Equals((object) this._Setup, (object) ((BillOfProcessOverride) obj)._Setup) && object.Equals((object) this._IsFrozen, (object) ((BillOfProcessOverride) obj)._IsFrozen))) && base.Equals(obj);
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

    public ContainerESigTxnMap[] ESigTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigTxnMap), (object) value);
      }
      get
      {
        return (ContainerESigTxnMap[]) this.PropertyGet(nameof (ESigTxnMap));
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

    public ContainerLabelMap[] LabelTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTxnMap), (object) value);
      }
      get
      {
        return (ContainerLabelMap[]) this.PropertyGet(nameof (LabelTxnMap));
      }
    }

    public Camstar.WCF.ObjectStack.TxnMap[] TxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnMap), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.TxnMap[]) this.PropertyGet(nameof (TxnMap));
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
  }
}
