// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PortalMenuCommandChanges
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
  public class PortalMenuCommandChanges : PortalMenuItemChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_QueryString")]
    protected Primitive<string> _QueryString;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_PageURL")]
    protected Primitive<string> _PageURL;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_PageDisplay")]
    protected Enumeration<NewBrowserDisplayEnum, int> _PageDisplay;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_StartPage")]
    protected NamedObjectRef _StartPage;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_VirtualPage")]
    protected NamedObjectRef _VirtualPage;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_PageFlow")]
    protected NamedObjectRef _PageFlow;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_ServiceName")]
    protected Primitive<string> _ServiceName;

    public override bool Equals(object obj)
    {
      return obj is PortalMenuCommandChanges && object.Equals((object) this._QueryString, (object) ((PortalMenuCommandChanges) obj)._QueryString) && (object.Equals((object) this._PageURL, (object) ((PortalMenuCommandChanges) obj)._PageURL) && object.Equals((object) this._PageDisplay, (object) ((PortalMenuCommandChanges) obj)._PageDisplay)) && (object.Equals((object) this._StartPage, (object) ((PortalMenuCommandChanges) obj)._StartPage) && object.Equals((object) this._VirtualPage, (object) ((PortalMenuCommandChanges) obj)._VirtualPage) && (object.Equals((object) this._PageFlow, (object) ((PortalMenuCommandChanges) obj)._PageFlow) && object.Equals((object) this._ListItemToChange, (object) ((PortalMenuCommandChanges) obj)._ListItemToChange))) && (object.Equals((object) this._ObjectToChange, (object) ((PortalMenuCommandChanges) obj)._ObjectToChange) && object.Equals((object) this._ServiceName, (object) ((PortalMenuCommandChanges) obj)._ServiceName)) && base.Equals(obj);
    }

    public Primitive<string> QueryString
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryString), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QueryString));
      }
    }

    public Primitive<string> PageURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (PageURL), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PageURL));
      }
    }

    public Enumeration<NewBrowserDisplayEnum, int> PageDisplay
    {
      [param: In] set
      {
        this.PropertySet(nameof (PageDisplay), (object) value);
      }
      get
      {
        return (Enumeration<NewBrowserDisplayEnum, int>) this.PropertyGet(nameof (PageDisplay));
      }
    }

    public NamedObjectRef StartPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartPage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (StartPage));
      }
    }

    public NamedObjectRef VirtualPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (VirtualPage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (VirtualPage));
      }
    }

    public NamedObjectRef PageFlow
    {
      [param: In] set
      {
        this.PropertySet(nameof (PageFlow), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PageFlow));
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

    public Primitive<string> ServiceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ServiceName));
      }
    }
  }
}
