// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WebPartChanges_Environment
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
  public class WebPartChanges_Environment : UIProviderComponentChanges_Environment
  {
    [Metadata("UI Personalization data", "UIPersonalizationChanges", false, false, false, "UIPersonalizationChanges", 1052352, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WebPartChanges_Environment_DeveloperPersonalization")]
    protected UIPersonalizationChanges_Environment _DeveloperPersonalization;
    [Metadata("UI Personalization data", "UIPersonalizationChanges", false, false, false, "UIPersonalizationChanges", 1053271, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WebPartChanges_Environment_WorkspacePersonalizations")]
    protected UIPersonalizationChanges_Environment _WorkspacePersonalizations;
    [Metadata("A web part is a piece of a web page that performs a specific function, but is not intended to run as a page on its own", "WebPart", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "WebPartChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052436, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WebPartChanges_Environment_Name")]
    protected new Environment _Name;

    public UIPersonalizationChanges_Environment DeveloperPersonalization
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeveloperPersonalization), (object) value);
      }
      get
      {
        return (UIPersonalizationChanges_Environment) this.PropertyGet(nameof (DeveloperPersonalization));
      }
    }

    public UIPersonalizationChanges_Environment WorkspacePersonalizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkspacePersonalizations), (object) value);
      }
      get
      {
        return (UIPersonalizationChanges_Environment) this.PropertyGet(nameof (WorkspacePersonalizations));
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

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
