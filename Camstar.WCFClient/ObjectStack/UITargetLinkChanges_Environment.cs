// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UITargetLinkChanges_Environment
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
  public class UITargetLinkChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("UI Target Link", "UITargetLinkChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UITargetLinkChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("Storages Links definition for UITarget", "UITargetLink", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UITargetLinkChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Generic String", "", false, false, false, "String", 1052745, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UITargetLinkChanges_Environment_TargetMember")]
    protected Environment _TargetMember;
    [DataMember(EmitDefaultValue = false, Name = "UITargetLinkChanges_Environment_SourceMember")]
    [Metadata("Generic String", "", false, false, false, "String", 1052743, false, false, false, null)]
    protected Environment _SourceMember;
    [DataMember(EmitDefaultValue = false, Name = "UITargetLinkChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
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

    public Environment TargetMember
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetMember), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetMember));
      }
    }

    public Environment SourceMember
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceMember), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SourceMember));
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
