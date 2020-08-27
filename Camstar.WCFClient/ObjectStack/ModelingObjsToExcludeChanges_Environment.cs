// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ModelingObjsToExcludeChanges_Environment
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
  public class ModelingObjsToExcludeChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("DisplayName", "", false, false, true, "String", 1049720, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingObjsToExcludeChanges_Environment_DisplayName")]
    protected new Environment _DisplayName;
    [Metadata("Generic list of objects", "ModelingObjsToExclude", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingObjsToExcludeChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1049647, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingObjsToExcludeChanges_Environment_ModelingCDOTypeId")]
    protected Environment _ModelingCDOTypeId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingObjsToExcludeChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;

    public new Environment DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayName));
      }
    }

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

    public Environment ModelingCDOTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingCDOTypeId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ModelingCDOTypeId));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
