// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ITeamMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ITeamMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      TeamMaint teamMaint,
      TeamMaint_Parameters parameters,
      TeamMaint_Request request,
      out TeamMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      TeamMaint teamMaint,
      TeamMaint_Parameters parameters,
      TeamMaint_Request request,
      out TeamMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      TeamMaint teamMaint,
      TeamMaint_Parameters parameters,
      TeamMaint_Request request,
      out TeamMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      TeamMaint teamMaint,
      TeamMaint_Parameters parameters,
      TeamMaint_Request request,
      out TeamMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      TeamMaint teamMaint,
      TeamMaint_LoadESigDetails_Parameters parameters,
      TeamMaint_Request request,
      out TeamMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      TeamMaint teamMaint,
      TeamMaint_Parameters parameters,
      TeamMaint_Request request,
      out TeamMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      TeamMaint teamMaint,
      TeamMaint_Parameters parameters,
      TeamMaint_Request request,
      out TeamMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      TeamMaint teamMaint,
      TeamMaint_Parameters parameters,
      TeamMaint_Request request,
      out TeamMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      TeamMaint teamMaint,
      TeamMaint_Parameters parameters,
      TeamMaint_Request request,
      out TeamMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      TeamMaintMethod[] methods,
      TeamMaint_Request request,
      out TeamMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      TeamMaint teamMaint,
      TeamMaint_Request request,
      out TeamMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      TeamMaint teamMaint,
      TeamMaint_Request request,
      out TeamMaint_Result result);
  }
}
