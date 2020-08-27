// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IProcessListMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IProcessListMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ProcessListMaint processListMaint,
      ProcessListMaint_LoadESigDetails_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ProcessListMaint processListMaint,
      ProcessListMaint_Parameters parameters,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ProcessListMaintMethod[] methods,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ProcessListMaint processListMaint,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ProcessListMaint processListMaint,
      ProcessListMaint_Request request,
      out ProcessListMaint_Result result);
  }
}
