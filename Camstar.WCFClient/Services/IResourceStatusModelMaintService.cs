// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IResourceStatusModelMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IResourceStatusModelMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Parameters parameters,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Parameters parameters,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Parameters parameters,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Parameters parameters,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_LoadESigDetails_Parameters parameters,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Parameters parameters,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Parameters parameters,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Parameters parameters,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Parameters parameters,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ResourceStatusModelMaintMethod[] methods,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result);
  }
}
