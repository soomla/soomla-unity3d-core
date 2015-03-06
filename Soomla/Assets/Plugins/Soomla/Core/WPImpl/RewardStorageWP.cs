/// Copyright (C) 2012-2014 Soomla Inc.
///
/// Licensed under the Apache License, Version 2.0 (the "License");
/// you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at
///
///      http://www.apache.org/licenses/LICENSE-2.0
///
/// Unless required by applicable law or agreed to in writing, software
/// distributed under the License is distributed on an "AS IS" BASIS,
/// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
/// See the License for the specific language governing permissions and
/// limitations under the License.

using UnityEngine;
using System;

namespace Soomla {
	
	public class RewardStorageWP : RewardStorage {

#if UNITY_WP8 && UNITY_EDITOR
		
		override protected int _getLastSeqIdxGiven(SequenceReward reward) {
			int idx = -1;
            SoomlaUtils.LogDebug("RewardStorageWP", "TODO implement _getLastSeqIdxGiven");
			return idx;
		}
		
		override protected void _setLastSeqIdxGiven(SequenceReward reward, int idx) {
            SoomlaUtils.LogDebug("RewardStorageWP", "TODO implement _setLastSeqIdxGiven");
		}
		
		override protected void _setTimesGiven(Reward reward, bool up, bool notify) {

            SoomlaUtils.LogDebug("RewardStorageWP", "TODO implement _setTimesGiven");
		}
		
		override protected int _getTimesGiven(Reward reward) {
			int times = 0;
            SoomlaUtils.LogDebug("RewardStorageWP", "TODO implement _getTimesGiven");
			return times;
		}
		
		override protected DateTime _getLastGivenTime(Reward reward) {
			long lastTime = 0;
            SoomlaUtils.LogDebug("RewardStorageWP", "TODO implement _getLastGivenTime");

			TimeSpan time = TimeSpan.FromMilliseconds(lastTime);
			return new DateTime(time.Ticks);
		}


#endif
	}
}
