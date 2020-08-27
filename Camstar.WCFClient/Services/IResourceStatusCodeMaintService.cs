// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IResourceStatusCodeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IResourceStatusCodeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Parameters parameters,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Parameters parameters,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Parameters parameters,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Parameters parameters,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_LoadESigDetails_Parameters parameters,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Parameters parameters,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Parameters parameters,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Parameters parameters,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Parameters parameters,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ResourceStatusCodeMaintMethod[] methods,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result);
  }
}
