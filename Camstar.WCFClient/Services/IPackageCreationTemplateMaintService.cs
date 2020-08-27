// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPackageCreationTemplateMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPackageCreationTemplateMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Parameters parameters,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Parameters parameters,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Parameters parameters,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Parameters parameters,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_LoadESigDetails_Parameters parameters,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Parameters parameters,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Parameters parameters,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Parameters parameters,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Parameters parameters,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PackageCreationTemplateMaintMethod[] methods,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result);
  }
}
