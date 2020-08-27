// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IEMailMessageMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IEMailMessageMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Parameters parameters,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Parameters parameters,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Parameters parameters,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Parameters parameters,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_LoadESigDetails_Parameters parameters,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Parameters parameters,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Parameters parameters,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Parameters parameters,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Parameters parameters,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      EMailMessageMaintMethod[] methods,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result);
  }
}
