// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ApplicationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ApplicationMaintService : NamedDataObjectMaintBase
  {
    public ApplicationMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IApplicationMaintService), userProfile);
    }

    public ResultStatus Delete(
      ApplicationMaint applicationMaint,
      ApplicationMaint_Parameters parameters,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      result = (ApplicationMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) applicationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApplicationMaintService) this._Channel).Delete(this._UserProfile, applicationMaint, parameters, request, out result) : this.AddMethod((Method) new ApplicationMaintMethod(applicationMaint, ApplicationMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) applicationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ApplicationMaint) null, (ApplicationMaint_Parameters) null, (ApplicationMaint_Request) null, out ApplicationMaint_Result _);
    }

    public ResultStatus Delete(ApplicationMaint applicationMaint)
    {
      return this.Delete(applicationMaint, (ApplicationMaint_Parameters) null, (ApplicationMaint_Request) null, out ApplicationMaint_Result _);
    }

    public ResultStatus Delete(
      ApplicationMaint applicationMaint,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      return this.Delete(applicationMaint, (ApplicationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ApplicationMaint applicationMaint,
      ApplicationMaint_Parameters parameters,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      result = (ApplicationMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) applicationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApplicationMaintService) this._Channel).Freeze(this._UserProfile, applicationMaint, parameters, request, out result) : this.AddMethod((Method) new ApplicationMaintMethod(applicationMaint, ApplicationMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) applicationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ApplicationMaint) null, (ApplicationMaint_Parameters) null, (ApplicationMaint_Request) null, out ApplicationMaint_Result _);
    }

    public ResultStatus Freeze(ApplicationMaint applicationMaint)
    {
      return this.Freeze(applicationMaint, (ApplicationMaint_Parameters) null, (ApplicationMaint_Request) null, out ApplicationMaint_Result _);
    }

    public ResultStatus Freeze(
      ApplicationMaint applicationMaint,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      return this.Freeze(applicationMaint, (ApplicationMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ApplicationMaint applicationMaint,
      ApplicationMaint_Parameters parameters,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      result = (ApplicationMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) applicationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApplicationMaintService) this._Channel).GetWIPMsgs(this._UserProfile, applicationMaint, parameters, request, out result) : this.AddMethod((Method) new ApplicationMaintMethod(applicationMaint, ApplicationMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) applicationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ApplicationMaint) null, (ApplicationMaint_Parameters) null, (ApplicationMaint_Request) null, out ApplicationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ApplicationMaint applicationMaint)
    {
      return this.GetWIPMsgs(applicationMaint, (ApplicationMaint_Parameters) null, (ApplicationMaint_Request) null, out ApplicationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ApplicationMaint applicationMaint,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      return this.GetWIPMsgs(applicationMaint, (ApplicationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ApplicationMaint applicationMaint,
      ApplicationMaint_Parameters parameters,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      result = (ApplicationMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) applicationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApplicationMaintService) this._Channel).Load(this._UserProfile, applicationMaint, parameters, request, out result) : this.AddMethod((Method) new ApplicationMaintMethod(applicationMaint, ApplicationMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) applicationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ApplicationMaint) null, (ApplicationMaint_Parameters) null, (ApplicationMaint_Request) null, out ApplicationMaint_Result _);
    }

    public ResultStatus Load(ApplicationMaint applicationMaint)
    {
      return this.Load(applicationMaint, (ApplicationMaint_Parameters) null, (ApplicationMaint_Request) null, out ApplicationMaint_Result _);
    }

    public ResultStatus Load(
      ApplicationMaint applicationMaint,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      return this.Load(applicationMaint, (ApplicationMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ApplicationMaint applicationMaint,
      ApplicationMaint_LoadESigDetails_Parameters parameters,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      result = (ApplicationMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) applicationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApplicationMaintService) this._Channel).LoadESigDetails(this._UserProfile, applicationMaint, parameters, request, out result) : this.AddMethod((Method) new ApplicationMaintMethod(applicationMaint, ApplicationMaintMethods.LoadESigDetails, (ApplicationMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) applicationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ApplicationMaint) null, (ApplicationMaint_LoadESigDetails_Parameters) null, (ApplicationMaint_Request) null, out ApplicationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ApplicationMaint applicationMaint)
    {
      return this.LoadESigDetails(applicationMaint, (ApplicationMaint_LoadESigDetails_Parameters) null, (ApplicationMaint_Request) null, out ApplicationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ApplicationMaint applicationMaint,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      return this.LoadESigDetails(applicationMaint, (ApplicationMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ApplicationMaint applicationMaint,
      ApplicationMaint_Parameters parameters,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      result = (ApplicationMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) applicationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApplicationMaintService) this._Channel).New(this._UserProfile, applicationMaint, parameters, request, out result) : this.AddMethod((Method) new ApplicationMaintMethod(applicationMaint, ApplicationMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) applicationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ApplicationMaint) null, (ApplicationMaint_Parameters) null, (ApplicationMaint_Request) null, out ApplicationMaint_Result _);
    }

    public ResultStatus New(ApplicationMaint applicationMaint)
    {
      return this.New(applicationMaint, (ApplicationMaint_Parameters) null, (ApplicationMaint_Request) null, out ApplicationMaint_Result _);
    }

    public ResultStatus New(
      ApplicationMaint applicationMaint,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      return this.New(applicationMaint, (ApplicationMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ApplicationMaint applicationMaint,
      ApplicationMaint_Parameters parameters,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      result = (ApplicationMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) applicationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApplicationMaintService) this._Channel).NewCopy(this._UserProfile, applicationMaint, parameters, request, out result) : this.AddMethod((Method) new ApplicationMaintMethod(applicationMaint, ApplicationMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) applicationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ApplicationMaint) null, (ApplicationMaint_Parameters) null, (ApplicationMaint_Request) null, out ApplicationMaint_Result _);
    }

    public ResultStatus NewCopy(ApplicationMaint applicationMaint)
    {
      return this.NewCopy(applicationMaint, (ApplicationMaint_Parameters) null, (ApplicationMaint_Request) null, out ApplicationMaint_Result _);
    }

    public ResultStatus NewCopy(
      ApplicationMaint applicationMaint,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      return this.NewCopy(applicationMaint, (ApplicationMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ApplicationMaint applicationMaint,
      ApplicationMaint_Parameters parameters,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      result = (ApplicationMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) applicationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApplicationMaintService) this._Channel).SaveAs(this._UserProfile, applicationMaint, parameters, request, out result) : this.AddMethod((Method) new ApplicationMaintMethod(applicationMaint, ApplicationMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) applicationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ApplicationMaint) null, (ApplicationMaint_Parameters) null, (ApplicationMaint_Request) null, out ApplicationMaint_Result _);
    }

    public ResultStatus SaveAs(ApplicationMaint applicationMaint)
    {
      return this.SaveAs(applicationMaint, (ApplicationMaint_Parameters) null, (ApplicationMaint_Request) null, out ApplicationMaint_Result _);
    }

    public ResultStatus SaveAs(
      ApplicationMaint applicationMaint,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      return this.SaveAs(applicationMaint, (ApplicationMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ApplicationMaint applicationMaint,
      ApplicationMaint_Parameters parameters,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      result = (ApplicationMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) applicationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApplicationMaintService) this._Channel).UnFreeze(this._UserProfile, applicationMaint, parameters, request, out result) : this.AddMethod((Method) new ApplicationMaintMethod(applicationMaint, ApplicationMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) applicationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ApplicationMaint) null, (ApplicationMaint_Parameters) null, (ApplicationMaint_Request) null, out ApplicationMaint_Result _);
    }

    public ResultStatus UnFreeze(ApplicationMaint applicationMaint)
    {
      return this.UnFreeze(applicationMaint, (ApplicationMaint_Parameters) null, (ApplicationMaint_Request) null, out ApplicationMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ApplicationMaint applicationMaint,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      return this.UnFreeze(applicationMaint, (ApplicationMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject applicationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApplicationMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ApplicationMaint) applicationMaint, (ApplicationMaint_Parameters) parameters, (ApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject applicationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApplicationMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ApplicationMaint) applicationMaint, (ApplicationMaint_Parameters) parameters, (ApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject applicationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApplicationMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ApplicationMaint) applicationMaint, (ApplicationMaint_LoadESigDetails_Parameters) parameters, (ApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject applicationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApplicationMaint_Result result1;
        ResultStatus resultStatus = this.New((ApplicationMaint) applicationMaint, (ApplicationMaint_Parameters) parameters, (ApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject applicationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApplicationMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ApplicationMaint) applicationMaint, (ApplicationMaint_Parameters) parameters, (ApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject applicationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApplicationMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ApplicationMaint) applicationMaint, (ApplicationMaint_Parameters) parameters, (ApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject applicationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApplicationMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ApplicationMaint) applicationMaint, (ApplicationMaint_Parameters) parameters, (ApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject applicationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApplicationMaint_Result result1;
        ResultStatus resultStatus = this.Load((ApplicationMaint) applicationMaint, (ApplicationMaint_Parameters) parameters, (ApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject applicationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApplicationMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ApplicationMaint) applicationMaint, (ApplicationMaint_Parameters) parameters, (ApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      result = (ApplicationMaint_Result) null;
      try
      {
        ApplicationMaintMethod[] methods = new ApplicationMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IApplicationMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ApplicationMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ApplicationMaint cdo,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      result = (ApplicationMaint_Result) null;
      try
      {
        return ((IApplicationMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ApplicationMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ApplicationMaint) cdo, (ApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      return this.GetEnvironment((ApplicationMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ApplicationMaint cdo,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      result = (ApplicationMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApplicationMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ApplicationMaintMethod(cdo, ApplicationMaintMethods.ExecuteTransaction, (ApplicationMaint_Parameters) null));
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
        ApplicationMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ApplicationMaint) cdo, (ApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ApplicationMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ApplicationMaint_Request) null, out ApplicationMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result)
    {
      return this.ExecuteTransaction((ApplicationMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ApplicationMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ApplicationMaintMethod(cdo, ApplicationMaintMethods.AddDataTransaction, (ApplicationMaint_Parameters) null));
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
        return this.AddDataTransaction((ApplicationMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
