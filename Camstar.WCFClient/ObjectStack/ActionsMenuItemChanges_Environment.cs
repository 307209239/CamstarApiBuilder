// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionsMenuItemChanges_Environment
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
  public class ActionsMenuItemChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuItemChanges_Environment_Caption")]
    [Metadata("Caption", "", false, true, false, "String", 1049386, false, false, false, null)]
    protected Environment _Caption;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuItemChanges_Environment_Sequence")]
    [Metadata("Relative sequence number", "", false, false, false, "Integer", 1048917, false, false, false, "0")]
    protected Environment _Sequence;
    [Metadata("Field Expression.", "", false, false, false, "String", 1052555, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuItemChanges_Environment_OptionalParameters")]
    protected Environment _OptionalParameters;
    [Metadata("An instance of a ActionsMenuItemis used to define an entry within a ActionsMenu. Each ActionsMenuItem defines a reference to UIVirtualPage.", "ActionsMenuItemChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuItemChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, true, false, "NamedObjectRef", 1052556, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuItemChanges_Environment_UIVirtualPage")]
    protected Environment _UIVirtualPage;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuItemChanges_Environment_ObjectToChange")]
    [Metadata("An instance of a ActionsMenuItemis used to define an entry within a ActionsMenu. Each ActionsMenuItem defines a reference to UIVirtualPage.", "ActionsMenuItem", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuItemChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public Environment Caption
    {
      [param: In] set
      {
        this.PropertySet(nameof (Caption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Caption));
      }
    }

    public Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
      }
    }

    public Environment OptionalParameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (OptionalParameters), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OptionalParameters));
      }
    }

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

    public Environment UIVirtualPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIVirtualPage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UIVirtualPage));
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
