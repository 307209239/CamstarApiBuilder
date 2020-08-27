// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PackageCreationTemplateMaint_Environment
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
  public class PackageCreationTemplateMaint_Environment : NamedDataObjectMaint_Environment
  {
    [Metadata("Package Creation Template", "PackageCreationTemplate", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Package Creation Template", "PackageCreationTemplate", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateMaint_Environment_ObjectChanges")]
    [Metadata("Package Creation Template", "PackageCreationTemplateChanges", false, false, false, "PackageCreationTemplateChanges", 1048873, true, false, false, null)]
    protected PackageCreationTemplateChanges_Environment _ObjectChanges;
    [Metadata("Identifies a system as a target for various purposes such as export.  ", "TargetSystem", false, false, true, "TargetSystem", 16777320, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateMaint_Environment_SourceTargetSystem")]
    protected TargetSystem_Environment _SourceTargetSystem;

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public PackageCreationTemplateChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PackageCreationTemplateChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public TargetSystem_Environment SourceTargetSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceTargetSystem), (object) value);
      }
      get
      {
        return (TargetSystem_Environment) this.PropertyGet(nameof (SourceTargetSystem));
      }
    }
  }
}
