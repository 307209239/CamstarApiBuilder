// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PackageCreationTemplateMaint
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
  public class PackageCreationTemplateMaint : NamedDataObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateMaint_ObjectChanges")]
    protected PackageCreationTemplateChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateMaint_SourceTargetSystem")]
    protected TargetSystem _SourceTargetSystem;

    public override bool Equals(object obj)
    {
      return obj is PackageCreationTemplateMaint && object.Equals((object) this._ObjectToChange, (object) ((PackageCreationTemplateMaint) obj)._ObjectToChange) && (this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((PackageCreationTemplateMaint) obj)._ObjectListInquiry) && object.Equals((object) this._ObjectChanges, (object) ((PackageCreationTemplateMaint) obj)._ObjectChanges)) && object.Equals((object) this._SourceTargetSystem, (object) ((PackageCreationTemplateMaint) obj)._SourceTargetSystem) && base.Equals(obj);
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new NamedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public PackageCreationTemplateChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PackageCreationTemplateChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public TargetSystem SourceTargetSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceTargetSystem), (object) value);
      }
      get
      {
        return (TargetSystem) this.PropertyGet(nameof (SourceTargetSystem));
      }
    }
  }
}
