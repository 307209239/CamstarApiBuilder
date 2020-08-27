// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ScaleFamilyMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ScaleFamilyMaintService : ResourceFamilyMaintBase
  {
    public ScaleFamilyMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IScaleFamilyMaintService), userProfile);
    }

    public ResultStatus Delete(
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Parameters parameters,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      result = (ScaleFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) scaleFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleFamilyMaintService) this._Channel).Delete(this._UserProfile, scaleFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleFamilyMaintMethod(scaleFamilyMaint, ScaleFamilyMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) scaleFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ScaleFamilyMaint) null, (ScaleFamilyMaint_Parameters) null, (ScaleFamilyMaint_Request) null, out ScaleFamilyMaint_Result _);
    }

    public ResultStatus Delete(ScaleFamilyMaint scaleFamilyMaint)
    {
      return this.Delete(scaleFamilyMaint, (ScaleFamilyMaint_Parameters) null, (ScaleFamilyMaint_Request) null, out ScaleFamilyMaint_Result _);
    }

    public ResultStatus Delete(
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      return this.Delete(scaleFamilyMaint, (ScaleFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Parameters parameters,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      result = (ScaleFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) scaleFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleFamilyMaintService) this._Channel).Freeze(this._UserProfile, scaleFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleFamilyMaintMethod(scaleFamilyMaint, ScaleFamilyMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) scaleFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ScaleFamilyMaint) null, (ScaleFamilyMaint_Parameters) null, (ScaleFamilyMaint_Request) null, out ScaleFamilyMaint_Result _);
    }

    public ResultStatus Freeze(ScaleFamilyMaint scaleFamilyMaint)
    {
      return this.Freeze(scaleFamilyMaint, (ScaleFamilyMaint_Parameters) null, (ScaleFamilyMaint_Request) null, out ScaleFamilyMaint_Result _);
    }

    public ResultStatus Freeze(
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      return this.Freeze(scaleFamilyMaint, (ScaleFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Parameters parameters,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      result = (ScaleFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) scaleFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleFamilyMaintService) this._Channel).GetWIPMsgs(this._UserProfile, scaleFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleFamilyMaintMethod(scaleFamilyMaint, ScaleFamilyMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) scaleFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ScaleFamilyMaint) null, (ScaleFamilyMaint_Parameters) null, (ScaleFamilyMaint_Request) null, out ScaleFamilyMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ScaleFamilyMaint scaleFamilyMaint)
    {
      return this.GetWIPMsgs(scaleFamilyMaint, (ScaleFamilyMaint_Parameters) null, (ScaleFamilyMaint_Request) null, out ScaleFamilyMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      return this.GetWIPMsgs(scaleFamilyMaint, (ScaleFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Parameters parameters,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      result = (ScaleFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) scaleFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleFamilyMaintService) this._Channel).Load(this._UserProfile, scaleFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleFamilyMaintMethod(scaleFamilyMaint, ScaleFamilyMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) scaleFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ScaleFamilyMaint) null, (ScaleFamilyMaint_Parameters) null, (ScaleFamilyMaint_Request) null, out ScaleFamilyMaint_Result _);
    }

    public ResultStatus Load(ScaleFamilyMaint scaleFamilyMaint)
    {
      return this.Load(scaleFamilyMaint, (ScaleFamilyMaint_Parameters) null, (ScaleFamilyMaint_Request) null, out ScaleFamilyMaint_Result _);
    }

    public ResultStatus Load(
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      return this.Load(scaleFamilyMaint, (ScaleFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_LoadESigDetails_Parameters parameters,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      result = (ScaleFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) scaleFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleFamilyMaintService) this._Channel).LoadESigDetails(this._UserProfile, scaleFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleFamilyMaintMethod(scaleFamilyMaint, ScaleFamilyMaintMethods.LoadESigDetails, (ScaleFamilyMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) scaleFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ScaleFamilyMaint) null, (ScaleFamilyMaint_LoadESigDetails_Parameters) null, (ScaleFamilyMaint_Request) null, out ScaleFamilyMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ScaleFamilyMaint scaleFamilyMaint)
    {
      return this.LoadESigDetails(scaleFamilyMaint, (ScaleFamilyMaint_LoadESigDetails_Parameters) null, (ScaleFamilyMaint_Request) null, out ScaleFamilyMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      return this.LoadESigDetails(scaleFamilyMaint, (ScaleFamilyMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Parameters parameters,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      result = (ScaleFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) scaleFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleFamilyMaintService) this._Channel).New(this._UserProfile, scaleFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleFamilyMaintMethod(scaleFamilyMaint, ScaleFamilyMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) scaleFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ScaleFamilyMaint) null, (ScaleFamilyMaint_Parameters) null, (ScaleFamilyMaint_Request) null, out ScaleFamilyMaint_Result _);
    }

    public ResultStatus New(ScaleFamilyMaint scaleFamilyMaint)
    {
      return this.New(scaleFamilyMaint, (ScaleFamilyMaint_Parameters) null, (ScaleFamilyMaint_Request) null, out ScaleFamilyMaint_Result _);
    }

    public ResultStatus New(
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      return this.New(scaleFamilyMaint, (ScaleFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Parameters parameters,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      result = (ScaleFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) scaleFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleFamilyMaintService) this._Channel).NewCopy(this._UserProfile, scaleFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleFamilyMaintMethod(scaleFamilyMaint, ScaleFamilyMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) scaleFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ScaleFamilyMaint) null, (ScaleFamilyMaint_Parameters) null, (ScaleFamilyMaint_Request) null, out ScaleFamilyMaint_Result _);
    }

    public ResultStatus NewCopy(ScaleFamilyMaint scaleFamilyMaint)
    {
      return this.NewCopy(scaleFamilyMaint, (ScaleFamilyMaint_Parameters) null, (ScaleFamilyMaint_Request) null, out ScaleFamilyMaint_Result _);
    }

    public ResultStatus NewCopy(
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      return this.NewCopy(scaleFamilyMaint, (ScaleFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Parameters parameters,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      result = (ScaleFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) scaleFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleFamilyMaintService) this._Channel).SaveAs(this._UserProfile, scaleFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleFamilyMaintMethod(scaleFamilyMaint, ScaleFamilyMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) scaleFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ScaleFamilyMaint) null, (ScaleFamilyMaint_Parameters) null, (ScaleFamilyMaint_Request) null, out ScaleFamilyMaint_Result _);
    }

    public ResultStatus SaveAs(ScaleFamilyMaint scaleFamilyMaint)
    {
      return this.SaveAs(scaleFamilyMaint, (ScaleFamilyMaint_Parameters) null, (ScaleFamilyMaint_Request) null, out ScaleFamilyMaint_Result _);
    }

    public ResultStatus SaveAs(
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      return this.SaveAs(scaleFamilyMaint, (ScaleFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Parameters parameters,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      result = (ScaleFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) scaleFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleFamilyMaintService) this._Channel).UnFreeze(this._UserProfile, scaleFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleFamilyMaintMethod(scaleFamilyMaint, ScaleFamilyMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) scaleFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ScaleFamilyMaint) null, (ScaleFamilyMaint_Parameters) null, (ScaleFamilyMaint_Request) null, out ScaleFamilyMaint_Result _);
    }

    public ResultStatus UnFreeze(ScaleFamilyMaint scaleFamilyMaint)
    {
      return this.UnFreeze(scaleFamilyMaint, (ScaleFamilyMaint_Parameters) null, (ScaleFamilyMaint_Request) null, out ScaleFamilyMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      return this.UnFreeze(scaleFamilyMaint, (ScaleFamilyMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject scaleFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleFamilyMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ScaleFamilyMaint) scaleFamilyMaint, (ScaleFamilyMaint_Parameters) parameters, (ScaleFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject scaleFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleFamilyMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ScaleFamilyMaint) scaleFamilyMaint, (ScaleFamilyMaint_Parameters) parameters, (ScaleFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject scaleFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleFamilyMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ScaleFamilyMaint) scaleFamilyMaint, (ScaleFamilyMaint_LoadESigDetails_Parameters) parameters, (ScaleFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject scaleFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleFamilyMaint_Result result1;
        ResultStatus resultStatus = this.New((ScaleFamilyMaint) scaleFamilyMaint, (ScaleFamilyMaint_Parameters) parameters, (ScaleFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject scaleFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleFamilyMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ScaleFamilyMaint) scaleFamilyMaint, (ScaleFamilyMaint_Parameters) parameters, (ScaleFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject scaleFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleFamilyMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ScaleFamilyMaint) scaleFamilyMaint, (ScaleFamilyMaint_Parameters) parameters, (ScaleFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject scaleFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleFamilyMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ScaleFamilyMaint) scaleFamilyMaint, (ScaleFamilyMaint_Parameters) parameters, (ScaleFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject scaleFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleFamilyMaint_Result result1;
        ResultStatus resultStatus = this.Load((ScaleFamilyMaint) scaleFamilyMaint, (ScaleFamilyMaint_Parameters) parameters, (ScaleFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject scaleFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleFamilyMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ScaleFamilyMaint) scaleFamilyMaint, (ScaleFamilyMaint_Parameters) parameters, (ScaleFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      result = (ScaleFamilyMaint_Result) null;
      try
      {
        ScaleFamilyMaintMethod[] methods = new ScaleFamilyMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IScaleFamilyMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ScaleFamilyMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ScaleFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ScaleFamilyMaint cdo,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      result = (ScaleFamilyMaint_Result) null;
      try
      {
        return ((IScaleFamilyMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ScaleFamilyMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ScaleFamilyMaint) cdo, (ScaleFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      return this.GetEnvironment((ScaleFamilyMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ScaleFamilyMaint cdo,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      result = (ScaleFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleFamilyMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ScaleFamilyMaintMethod(cdo, ScaleFamilyMaintMethods.ExecuteTransaction, (ScaleFamilyMaint_Parameters) null));
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
        ScaleFamilyMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ScaleFamilyMaint) cdo, (ScaleFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ScaleFamilyMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ScaleFamilyMaint_Request) null, out ScaleFamilyMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result)
    {
      return this.ExecuteTransaction((ScaleFamilyMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ScaleFamilyMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ScaleFamilyMaintMethod(cdo, ScaleFamilyMaintMethods.AddDataTransaction, (ScaleFamilyMaint_Parameters) null));
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
        return this.AddDataTransaction((ScaleFamilyMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
