/**
 * 
 * @param {HTMLAudioElement} audio
 * @returns
 */
export function getCurrentTime(audio) {
    return audio.currentTime;
} 

/**
 * 
 * @param {HTMLAudioElement} audio
 * @param {number} value 
 * @returns
 */
export function setCurrentTime(audio, value) {
    return audio.currentTime = value;
} 

/**
 * 
 * @param {HTMLAudioElement} audio
 * @returns
 */
export function getDuration(audio) {
    return audio.duration;
} 
