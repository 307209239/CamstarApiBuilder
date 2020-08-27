// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerLevelMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ContainerLevelMaintService : NamedDataObjectMaintBase
  {
    public ContainerLevelMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IContainerLevelMaintService), userProfile);
    }

    public ResultStatus Delete(
      ContainerLevelMaint containerLevelMaint,
      ContainerLevelMaint_Parameters parameters,
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      result = (ContainerLevelMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) containerLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerLevelMaintService) this._Channel).Delete(this._UserProfile, containerLevelMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerLevelMaintMethod(containerLevelMaint, ContainerLevelMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) containerLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ContainerLevelMaint) null, (ContainerLevelMaint_Parameters) null, (ContainerLevelMaint_Request) null, out ContainerLevelMaint_Result _);
    }

    public ResultStatus Delete(ContainerLevelMaint containerLevelMaint)
    {
      return this.Delete(containerLevelMaint, (ContainerLevelMaint_Parameters) null, (ContainerLevelMaint_Request) null, out ContainerLevelMaint_Result _);
    }

    public ResultStatus Delete(
      ContainerLevelMaint containerLevelMaint,
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      return this.Delete(containerLevelMaint, (ContainerLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ContainerLevelMaint containerLevelMaint,
      ContainerLevelMaint_Parameters parameters,
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      result = (ContainerLevelMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) containerLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerLevelMaintService) this._Channel).Freeze(this._UserProfile, containerLevelMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerLevelMaintMethod(containerLevelMaint, ContainerLevelMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) containerLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ContainerLevelMaint) null, (ContainerLevelMaint_Parameters) null, (ContainerLevelMaint_Request) null, out ContainerLevelMaint_Result _);
    }

    public ResultStatus Freeze(ContainerLevelMaint containerLevelMaint)
    {
      return this.Freeze(containerLevelMaint, (ContainerLevelMaint_Parameters) null, (ContainerLevelMaint_Request) null, out ContainerLevelMaint_Result _);
    }

    public ResultStatus Freeze(
      ContainerLevelMaint containerLevelMaint,
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      return this.Freeze(containerLevelMaint, (ContainerLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ContainerLevelMaint containerLevelMaint,
      ContainerLevelMaint_Parameters parameters,
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      result = (ContainerLevelMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) containerLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerLevelMaintService) this._Channel).GetWIPMsgs(this._UserProfile, containerLevelMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerLevelMaintMethod(containerLevelMaint, ContainerLevelMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) containerLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ContainerLevelMaint) null, (ContainerLevelMaint_Parameters) null, (ContainerLevelMaint_Request) null, out ContainerLevelMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ContainerLevelMaint containerLevelMaint)
    {
      return this.GetWIPMsgs(containerLevelMaint, (ContainerLevelMaint_Parameters) null, (ContainerLevelMaint_Request) null, out ContainerLevelMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ContainerLevelMaint containerLevelMaint,
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      return this.GetWIPMsgs(containerLevelMaint, (ContainerLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ContainerLevelMaint containerLevelMaint,
      ContainerLevelMaint_Parameters parameters,
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      result = (ContainerLevelMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) containerLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerLevelMaintService) this._Channel).Load(this._UserProfile, containerLevelMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerLevelMaintMethod(containerLevelMaint, ContainerLevelMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) containerLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ContainerLevelMaint) null, (ContainerLevelMaint_Parameters) null, (ContainerLevelMaint_Request) null, out ContainerLevelMaint_Result _);
    }

    public ResultStatus Load(ContainerLevelMaint containerLevelMaint)
    {
      return this.Load(containerLevelMaint, (ContainerLevelMaint_Parameters) null, (ContainerLevelMaint_Request) null, out ContainerLevelMaint_Result _);
    }

    public ResultStatus Load(
      ContainerLevelMaint containerLevelMaint,
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      return this.Load(containerLevelMaint, (ContainerLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ContainerLevelMaint containerLevelMaint,
      ContainerLevelMaint_LoadESigDetails_Parameters parameters,
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      result = (ContainerLevelMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) containerLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerLevelMaintService) this._Channel).LoadESigDetails(this._UserProfile, containerLevelMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerLevelMaintMethod(containerLevelMaint, ContainerLevelMaintMethods.LoadESigDetails, (ContainerLevelMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) containerLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ContainerLevelMaint) null, (ContainerLevelMaint_LoadESigDetails_Parameters) null, (ContainerLevelMaint_Request) null, out ContainerLevelMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ContainerLevelMaint containerLevelMaint)
    {
      return this.LoadESigDetails(containerLevelMaint, (ContainerLevelMaint_LoadESigDetails_Parameters) null, (ContainerLevelMaint_Request) null, out ContainerLevelMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ContainerLevelMaint containerLevelMaint,
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      return this.LoadESigDetails(containerLevelMaint, (ContainerLevelMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ContainerLevelMaint containerLevelMaint,
      ContainerLevelMaint_Parameters parameters,
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      result = (ContainerLevelMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) containerLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerLevelMaintService) this._Channel).New(this._UserProfile, containerLevelMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerLevelMaintMethod(containerLevelMaint, ContainerLevelMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) containerLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ContainerLevelMaint) null, (ContainerLevelMaint_Parameters) null, (ContainerLevelMaint_Request) null, out ContainerLevelMaint_Result _);
    }

    public ResultStatus New(ContainerLevelMaint containerLevelMaint)
    {
      return this.New(containerLevelMaint, (ContainerLevelMaint_Parameters) null, (ContainerLevelMaint_Request) null, out ContainerLevelMaint_Result _);
    }

    public ResultStatus New(
      ContainerLevelMaint containerLevelMaint,
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      return this.New(containerLevelMaint, (ContainerLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ContainerLevelMaint containerLevelMaint,
      ContainerLevelMaint_Parameters parameters,
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      result = (ContainerLevelMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) containerLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerLevelMaintService) this._Channel).NewCopy(this._UserProfile, containerLevelMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerLevelMaintMethod(containerLevelMaint, ContainerLevelMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) containerLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ContainerLevelMaint) null, (ContainerLevelMaint_Parameters) null, (ContainerLevelMaint_Request) null, out ContainerLevelMaint_Result _);
    }

    public ResultStatus NewCopy(ContainerLevelMaint containerLevelMaint)
    {
      return this.NewCopy(containerLevelMaint, (ContainerLevelMaint_Parameters) null, (ContainerLevelMaint_Request) null, out ContainerLevelMaint_Result _);
    }

    public ResultStatus NewCopy(
      ContainerLevelMaint containerLevelMaint,
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      return this.NewCopy(containerLevelMaint, (ContainerLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ContainerLevelMaint containerLevelMaint,
      ContainerLevelMaint_Parameters parameters,
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      result = (ContainerLevelMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) containerLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerLevelMaintService) this._Channel).SaveAs(this._UserProfile, containerLevelMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerLevelMaintMethod(containerLevelMaint, ContainerLevelMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) containerLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ContainerLevelMaint) null, (ContainerLevelMaint_Parameters) null, (ContainerLevelMaint_Request) null, out ContainerLevelMaint_Result _);
    }

    public ResultStatus SaveAs(ContainerLevelMaint containerLevelMaint)
    {
      return this.SaveAs(containerLevelMaint, (ContainerLevelMaint_Parameters) null, (ContainerLevelMaint_Request) null, out ContainerLevelMaint_Result _);
    }

    public ResultStatus SaveAs(
      ContainerLevelMaint containerLevelMaint,
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      return this.SaveAs(containerLevelMaint, (ContainerLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ContainerLevelMaint containerLevelMaint,
      ContainerLevelMaint_Parameters parameters,
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      result = (ContainerLevelMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) containerLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerLevelMaintService) this._Channel).UnFreeze(this._UserProfile, containerLevelMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerLevelMaintMethod(containerLevelMaint, ContainerLevelMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) containerLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ContainerLevelMaint) null, (ContainerLevelMaint_Parameters) null, (ContainerLevelMaint_Request) null, out ContainerLevelMaint_Result _);
    }

    public ResultStatus UnFreeze(ContainerLevelMaint containerLevelMaint)
    {
      return this.UnFreeze(containerLevelMaint, (ContainerLevelMaint_Parameters) null, (ContainerLevelMaint_Request) null, out ContainerLevelMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ContainerLevelMaint containerLevelMaint,
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      return this.UnFreeze(containerLevelMaint, (ContainerLevelMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject containerLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerLevelMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ContainerLevelMaint) containerLevelMaint, (ContainerLevelMaint_Parameters) parameters, (ContainerLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject containerLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerLevelMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ContainerLevelMaint) containerLevelMaint, (ContainerLevelMaint_Parameters) parameters, (ContainerLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject containerLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerLevelMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ContainerLevelMaint) containerLevelMaint, (ContainerLevelMaint_LoadESigDetails_Parameters) parameters, (ContainerLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject containerLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerLevelMaint_Result result1;
        ResultStatus resultStatus = this.New((ContainerLevelMaint) containerLevelMaint, (ContainerLevelMaint_Parameters) parameters, (ContainerLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject containerLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerLevelMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ContainerLevelMaint) containerLevelMaint, (ContainerLevelMaint_Parameters) parameters, (ContainerLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject containerLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerLevelMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ContainerLevelMaint) containerLevelMaint, (ContainerLevelMaint_Parameters) parameters, (ContainerLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject containerLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerLevelMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ContainerLevelMaint) containerLevelMaint, (ContainerLevelMaint_Parameters) parameters, (ContainerLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject containerLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerLevelMaint_Result result1;
        ResultStatus resultStatus = this.Load((ContainerLevelMaint) containerLevelMaint, (ContainerLevelMaint_Parameters) parameters, (ContainerLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject containerLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerLevelMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ContainerLevelMaint) containerLevelMaint, (ContainerLevelMaint_Parameters) parameters, (ContainerLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      result = (ContainerLevelMaint_Result) null;
      try
      {
        ContainerLevelMaintMethod[] methods = new ContainerLevelMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IContainerLevelMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerLevelMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ContainerLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerLevelMaint cdo,
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      result = (ContainerLevelMaint_Result) null;
      try
      {
        return ((IContainerLevelMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerLevelMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ContainerLevelMaint) cdo, (ContainerLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      return this.GetEnvironment((ContainerLevelMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ContainerLevelMaint cdo,
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      result = (ContainerLevelMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerLevelMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ContainerLevelMaintMethod(cdo, ContainerLevelMaintMethods.ExecuteTransaction, (ContainerLevelMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerLevelMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ContainerLevelMaint) cdo, (ContainerLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ContainerLevelMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ContainerLevelMaint_Request) null, out ContainerLevelMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ContainerLevelMaint_Request request,
      out ContainerLevelMaint_Result result)
    {
      return this.ExecuteTransaction((ContainerLevelMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ContainerLevelMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ContainerLevelMaintMethod(cdo, ContainerLevelMaintMethods.AddDataTransaction, (ContainerLevelMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((ContainerLevelMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
