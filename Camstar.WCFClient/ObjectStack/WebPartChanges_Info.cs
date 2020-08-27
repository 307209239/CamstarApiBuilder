// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WebPartChanges_Info
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
  public class WebPartChanges_Info : UIProviderComponentChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WebPartChanges_Info_DeveloperPersonalization")]
    protected UIPersonalizationChanges_Info _DeveloperPersonalization;
    [DataMember(EmitDefaultValue = false, Name = "WebPartChanges_Info_WorkspacePersonalizations")]
    protected UIPersonalizationChanges_Info _WorkspacePersonalizations;
    [DataMember(EmitDefaultValue = false, Name = "WebPartChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WebPartChanges_Info_Name")]
    protected new Info _Name;

    public UIPersonalizationChanges_Info DeveloperPersonalization
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeveloperPersonalization), (object) value);
      }
      get
      {
        return (UIPersonalizationChanges_Info) this.PropertyGet(nameof (DeveloperPersonalization));
      }
    }

    public UIPersonalizationChanges_Info WorkspacePersonalizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkspacePersonalizations), (object) value);
      }
      get
      {
        return (UIPersonalizationChanges_Info) this.PropertyGet(nameof (WorkspacePersonalizations));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
